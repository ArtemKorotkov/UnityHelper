using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretegyExample : MonoBehaviour
{
    public interface IAction
    {
        public void RealisationAction();
    }
    
    public class Person
    {
        public void DoAction(IAction action)
        {
            Debug.Log("I am person and");
            action.RealisationAction(); 
        }
    }
    
    public class Jump: IAction
    {
        public void RealisationAction()
        {
            Debug.Log("I am jumping now");
        }
    }
    
    public class Run: IAction
    {
        public void RealisationAction()
        {
            Debug.Log("I am runing now");
        }
        
    }

    private Person person;
    private IAction jump;
    private IAction run;
    
    void Start()
    {
        person = new Person();
        jump = new Jump();
        run = new Run();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            person.DoAction(jump);
        else if (Input.GetKey(KeyCode.X))
            person.DoAction(run);
    }
}
