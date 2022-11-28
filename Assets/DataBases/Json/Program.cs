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

namespace json

{
    class Program

    {

    class Person
    {
        public int Age = 10;
        public string Name = "Artem";
    }
    

    public void SaveJsonExample()
    {
        Person person = new Person();

        string jsonData = JsonConvert.SerializeObject(person);

        Person person1 = JsonConvert.DeserializeObject<Person>(jsonData);

    }

    public static void SaveJsonExample2()
    {
        Word hello = new Word();

        hello.progress = 10;
        hello.EnglishValue = "hello";
        hello.RussianValue = "Привет";

        Folder test = new Folder();



        for (int i = 0; i < 3; i++)
        {
            Word a = new Word();
            a.progress = i;
            a.repeat = i;
            a.EnglishValue = "hello" + i;
            a.RussianValue = "Привет" + i;
            test.AddWord(a);

        }

        test.progress = 45;
        test.repeat = 1;


        string jsonData = JsonConvert.SerializeObject(test);
        Folder test2 = JsonConvert.DeserializeObject<Folder>(jsonData);


    }

 
    }
}