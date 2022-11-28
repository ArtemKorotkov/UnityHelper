using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Xml;

namespace XML

{
    class Program

    {

    class Person
    {
        public int Age = 10;
        public string Name = "Artem";
    }



    public void SaveXmlExample()
    {
        Person person = new Person();
        StreamWriter sw = new StreamWriter("hello", false);
        XElement Human = new XElement("Block");
        Human.Add(new XElement("HumanName", person.Name));
        Human.Add(new XElement("HumanName", person.Age));

        string result = Human.ToString();
        sw.WriteLine(result);
        sw.Close();

        var sr = new StreamReader("hello");
        string xmlCode = sr.ReadToEnd();
        sr.Close();
        XElement xBlock = XElement.Parse(xmlCode);


    }



    }
}