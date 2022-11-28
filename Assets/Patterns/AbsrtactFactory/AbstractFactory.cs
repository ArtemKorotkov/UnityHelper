using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactory : MonoBehaviour
{
    interface IEngine
    {
        public void ReleaseEngine();
    }

    class JapaneseEngine : IEngine
    { 
        public void ReleaseEngine()
        {
            Debug.Log("Японский двигатель");
        }
    }

    class RussianEngine : IEngine
    {
        public void ReleaseEngine()
        {
            Debug.Log("Русский двигатель");
        }
    }
    
    interface ICar
    {
        void ReleaseCar(IEngine engine);
    }


    class JapaniseCar: ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Debug.Log("Собрали японский автомобиль");
        }
    }
    
    class RussianCar: ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Debug.Log("Собрали российский автомобиль");
            engine.ReleaseEngine();
        }
    }

   
    interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }
    
    class JapaniseFacory: IFactory
    {
        public ICar CreateCar() => new JapaniseCar();
        public IEngine CreateEngine() => new JapaneseEngine();
    }
    

    class RussianFacory : IFactory
    {
        public ICar CreateCar() => new RussianCar();
        public IEngine CreateEngine() => new RussianEngine();
    }

    void Start()
    {
        IFactory JapFactory = new JapaniseFacory();
        IEngine JapEngine = new JapaneseEngine();
        ICar JapCar = JapFactory.CreateCar();
        
        JapCar.ReleaseCar(JapEngine);
        
        IFactory RusFactory = new RussianFacory();
        IEngine  RusEngine = new RussianEngine();
        ICar  RusCar = JapFactory.CreateCar();
        
        RusCar.ReleaseCar(RusEngine);
        
        


    }

    
}
