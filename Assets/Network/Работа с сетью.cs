using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;
using System.Threading.Tasks;

public class Работассеттю : MonoBehaviour
{
    public static bool Connection = false; //в игре будет брать значение из player prefs
    const int port = 8888; // порт для прослушивания подключений

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

        TcpListener server = null;
        try
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            server = new TcpListener(localAddr, port);

            // запуск слушателя
            server.Start();


            print("Ожидание подключений... ");

            // получаем входящее подключение
            TcpClient client = server.AcceptTcpClient();
            print("Подключен клиент. Выполнение запроса...");

            // получаем сетевой поток для чтения и записи
            NetworkStream stream = client.GetStream();

            // сообщение для отправки клиенту
            string response = "Привет мир";
            // преобразуем сообщение в массив байтов
            byte[] data = Encoding.UTF8.GetBytes(response);

            // отправка сообщения
            stream.Write(data, 0, data.Length);
            print("Отправлено сообщение: {0}");
            // закрываем поток
            stream.Close();
            // закрываем подключение
            client.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (server != null)
                server.Stop();
        }
        print("ОТВЕТ ОТ сервера Получен");
        Connection = true;

    }

    // определение асинхронного метода
    async Task PrintAsync()
    {
        await Task.Run(() => _Print());                // выполняется асинхронно
    }


}