using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;
using System.Threading.Tasks;

public class АСИНХРОННОСТЬ : MonoBehaviour
{
    public static bool Connection = false; 
    

    private void Start()
    {
        PrintAsync();
    }
    private void Update()
    {
        if (Connection)
        {
            print("ТЕЛО ЦИКЛА С подключением к Серверу");
        }
        else
        {
            print("ТЕЛО ЦИКЛА БЕЗ подключением к Серверу");
        }

    }


    void _Print() //Долгий метод
    {
        Thread.Sleep(3000);     // имитация продолжительной работы
        print("Hello METANIT.COM");

        Connection = true;

    }

    // определение асинхронного метода
    async Task PrintAsync()
    {
        print("Начало метода PrintAsync"); // выполняется синхронно
        await Task.Run(() => _Print());                // выполняется асинхронно
        print("Конец метода PrintAsync");
    }


}