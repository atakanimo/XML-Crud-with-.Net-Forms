using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AdvancoTask
{
    public class Document
    {
        [XmlElement(ElementName = "employee")]
        public List<Employee> document = new List<Employee>();
    }
    
    public class Employee
    {
        //[XmlElement(ElementName = "Members")]
        public Name name;
        public int personelID;
        public DateTime hireDate;
    }
    public class Name
    {
        public string firstname;
        public string surname;

    }
    //public class PersonelXML
    //{
    //    public NameSur Name;

    //    public int PersonalID;

    //    public DateTime HireDate;
    //}

    //public class NameSur
    //{
    //    public string FirstName;

    //    public string LastName;
    //}

}
