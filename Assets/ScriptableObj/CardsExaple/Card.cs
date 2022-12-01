using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObj
{
    [CreateAssetMenu(fileName = "Card", menuName = "ScriptableObject/Cards", order = 0)]
    public class Card : ScriptableObject
    {
        public string Name;
        public Texture Photo;
        public string Description;
    }
}