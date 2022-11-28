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

namespace Linq

{
    class Program

    {

    class Person
    {
        public int Age = 10;
        public string Name = "Artem";
    }
    

    public static void LinqExample()
    {

        Folder folder1 = new Folder();
        Folder folder2 = new Folder();


        for (int i = 1; i < 4; i++)
        {
            Word a = new Word();
            a.progress = i * 10;
            a.repeat = i * 10;
            a.EnglishValue = "goodby" + i;
            a.RussianValue = "пока" + i;
            folder1.AddWord(a);
        }

        for (int i = 1; i < 5; i++)
        {
            Word a = new Word();
            a.progress = i * 20;
            a.repeat = i * 20;
            a.EnglishValue = "hello" + i;
            a.RussianValue = "Привет" + i;
            folder2.AddWord(a);
        }

        var list1 = folder1.Words;
        var list2 = folder2.Words;

        list1.Add(list1[0]);

        list1 = list1.Distinct().ToList(); // удалит повторяющийся элемент

        list1.Reverse(); //изменяет порядок на обратный

        list1 = list1.Union(list2).ToList(); // объединяет list1 в list2

        list1 = list1.Skip(2).ToList(); // пропускает первые 2 элемента

        var list88 = list1.Where(x => x.progress > 10).ToList();

        list1 = list1.Where(x => x.progress > 20).ToList(); // взять элементы у которых прогресс больше 20

        list1 = list1.Where(word => word.EnglishValue.Contains("2"))
            .ToList(); // взять только слова у которых в названии есть2

        list1 = folder1.Words;
        

        list1 = list1.OrderByDescending(x => x.progress).ToList(); // сортировать по убыванию прогресса

        list1 = list1.OrderBy(x => x.progress).ToList(); // сортировать по увеличению прогресса

        var value = list1.OrderByDescending(x => x.progress).ToList()[0]; // выводит слово с наибольшим прогрессом

    }

   
    }
}