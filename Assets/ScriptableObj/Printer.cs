
using UnityEngine;

namespace Scriptable_Obj
{
    public class Printer : MonoBehaviour
    {
        private void Start()
        {
            //scriptable_obj.count = 10;
            print(scriptable_obj.count);
        }
    }
}