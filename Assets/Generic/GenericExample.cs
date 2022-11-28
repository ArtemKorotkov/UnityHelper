using System;
using System.Collections;
using System.Collections.Generic;
using Patterns.State;
using UnityEngine;
using UnityEngine.UIElements;

public class GenericExample : MonoBehaviour
{
   
    void Start()
    {
        
        Debug.Log(GetTypeMethod("11"));
        
        Debug.Log(GetTypeMethod2<string>());
        
        Debug.Log(GetTypeMethod3<type>());
        
    }

    public string GetTypeMethod<T>(T Parametr)
    {
        return typeof(T).ToString();
    }
    
    public string GetTypeMethod2<T>()
    {
        return typeof(T).ToString();
    }

    
    public interface Itype
    {
        
    }

    public class type: Itype
    {
        
    }
    public string GetTypeMethod3<T>() where T: Itype
    {
        return typeof(T).ToString();
    }

   


}
