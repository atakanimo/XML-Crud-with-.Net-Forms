using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AdvancoTask.XmlOperation
{
    public class İmportXmlDeserialize
    {
        public void Deserialize(string filepath)
        {

            XmlSerializer serializer =
            new XmlSerializer(typeof(Document));
            PersonelDal _personelDal = new PersonelDal();

            Document document;

            using (Stream reader = new FileStream(filepath, FileMode.Open))
            {
                document = (Document)serializer.Deserialize(reader);
            }

            foreach (var item in document.document)
            {
                var personalId = item.personelID;
                List<Personel> anyPersonList = _personelDal.GetAll(x => x.PersonalID == personalId);

                if (anyPersonList != null && anyPersonList.Count > 0)
                {
                    
                    Personel u_per = anyPersonList[0];

                    u_per.HireDate = item.hireDate;
                    u_per.Name = item.name.firstname.ToString();
                    u_per.Surname = item.name.surname.ToString();
                    u_per.PersonalID = Convert.ToInt32(item.personelID);
                    _personelDal.Update(u_per);
                }
                else
                {
                    _personelDal.Add(new Personel
                    {
                        Name = item.name.firstname,
                        Surname = item.name.surname,
                        PersonalID = Convert.ToInt32(item.personelID),
                        HireDate = Convert.ToDateTime(item.hireDate)
                    });
                }
            }

        }
    }
}
