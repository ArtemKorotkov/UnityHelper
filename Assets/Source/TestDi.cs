using System;
using System.ComponentModel;
using CryoDI;
using UnityEngine;

namespace Source
{
    public class TestDi : CryoBehaviour
    {
        [Dependency] public Camera Camera { get; set; }
        
        private void Update()
        {
            Debug.Log(Camera);
        }
    }
}