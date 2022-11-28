using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    
    interface IProduction
    {
        void Release();
    }

    class Car : IProduction
    {
        public void Release() => Debug.Log("Выпущен новый автомобиль");
        
    }
    
    

    class Truck : IProduction
    {
        public void Release() => Debug.Log("Выпущен новый грузовой автомобиль");
    }


    interface IWorkShop
    {
        IProduction Create();
    }

    class CarWprkshop : IWorkShop
    {
        public IProduction Create() => new Car();
    }

    class TruckWprkshop : IWorkShop
    {
        public IProduction Create() => new Truck();
    }

    void Start()
    {
        IWorkShop creator = new CarWprkshop();
        IProduction car = creator.Create();

        creator = new TruckWprkshop();
        IProduction truck = creator.Create();

        car.Release();
        truck.Release();
    }
}