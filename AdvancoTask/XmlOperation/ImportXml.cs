using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace AdvancoTask
{
    public class ImportXml
    {
        DataSet dataSet = new DataSet();
        PersonelDal _personelDal = new PersonelDal();
        int i = 0;
        public void ImportXmlCS(string Path)
        {
            try
            {
                XmlReader xmlFile = XmlReader.Create(Path, new XmlReaderSettings());
                dataSet.ReadXml(xmlFile);

                DataTable dt = dataSet.Tables[0];
                DataTable dtLast = dataSet.Tables["Name"];

                foreach (DataRow item in dt.Rows)
                {
                    string FirstName = "";
                    string Surname = "";

                    foreach (DataRow itemName in dtLast.Rows)
                    {
                        var EmployeeId = Convert.ToInt32(itemName["Employee_Id"].ToString());
                        if (EmployeeId == i)
                        {
                            FirstName = (itemName.Field<string>("FirstName"));    //XML Dosyasındaki Name Kısmını Okuma ve FirstName ile Surname i alma.
                            Surname = (itemName.Field<string>("Surname"));
                        }
                    }

                    var personelId = Convert.ToInt32(item["PersonelID"].ToString());
                    List<Personel> anyPersonList = _personelDal.GetAll(x => x.PersonalID == personelId);

                    if (anyPersonList != null && anyPersonList.Count > 0)
                    {
                        DateTime hiredate;
                        DateTime.TryParse(item["HireDate"].ToString(), out hiredate);
                        Personel u_per = anyPersonList[0];

                        u_per.HireDate = hiredate;
                        u_per.Name = FirstName;
                        u_per.Surname = Surname;
                        u_per.PersonalID = Convert.ToInt32(item["PersonelID"]);
                        _personelDal.Update(u_per);
                    }
                    else
                    {
                        _personelDal.Add(new Personel
                        {
                            Name = FirstName,
                            Surname = Surname,
                            PersonalID = Convert.ToInt32(item["PersonelID"]),
                            HireDate = Convert.ToDateTime(item["HireDate"])
                        });
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
