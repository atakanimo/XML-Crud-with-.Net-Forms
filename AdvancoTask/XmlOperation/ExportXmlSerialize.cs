using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AdvancoTask
{
    public class ExportXmlSerialize
    {
        PersonelDal _personelDal = new PersonelDal();
        List<Personel> personel = new List<Personel>();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public void CreateXML()
        {
            personel = _personelDal.GetAll();
            XmlSerializer serializer =
                new XmlSerializer(typeof(Document));
            TextWriter writer = new StreamWriter(path + @"\ExportedXML.xml");
            Document root = new Document();

            foreach (var item in personel)
            {
                Employee employee = new Employee();
                Name name = new Name();
                name.firstname = item.Name.Trim();
                name.surname = item.Surname.Trim();
                employee.name = name;
                employee.personelID = item.PersonalID;
                employee.hireDate = item.HireDate;
                root.document.Add(employee);
            }

            serializer.Serialize(writer, root);
        }
    }
}
