using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObj.ConfigExample
{
    [CreateAssetMenu(fileName = "Config", menuName = "ScriptableObject/Config", order = 0)]
    public class WorldConfig : ScriptableObject
    {
        public Dictionary<Pet, Parameters> blockSections;
        
    }

    [Serializable]
    public struct Parameters
    {
        private string _name;
        private string _value;
        private int _count;
    }

    [Serializable]
    public enum Pet
    {
       Chicken,
       Dog,
       Cat,
       Perot
    }


}