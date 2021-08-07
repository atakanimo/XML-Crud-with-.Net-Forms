using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

namespace AdvancoTask
{
    public class ExportXml
    {
        PersonelDal _personalDal = new PersonelDal();
        DataTable dataTable = new DataTable();
        DataSet dataSet = new DataSet();

        public void ExportXML()
        {
            List<Personel> expPersonal = _personalDal.GetAll();

            dataTable.TableName = "Employee";

            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("Surname");

            dataTable.Columns.Add("PersonalID");
            dataTable.Columns.Add("HireDate");

            foreach (var item in expPersonal)
            {
                dataTable.Rows.Add();

                dataTable.Rows[dataTable.Rows.Count - 1]["FirstName"] = item.Name.ToString().Trim();
                dataTable.Rows[dataTable.Rows.Count - 1]["Surname"] = item.Surname.ToString().Trim();
                dataTable.Rows[dataTable.Rows.Count - 1]["PersonalID"] = item.PersonalID.ToString().Trim();
                dataTable.Rows[dataTable.Rows.Count - 1]["HireDate"] = item.HireDate.ToString().Trim();
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            XmlTextWriter xmlSave = new XmlTextWriter(path + @"\ExportedXML.xml", Encoding.UTF8);
            xmlSave.Formatting = Formatting.Indented;

            dataTable.WriteXml(xmlSave);
        }
    }
}
