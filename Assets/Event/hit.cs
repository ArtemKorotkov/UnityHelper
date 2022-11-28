using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class hit: MonoBehaviour
{
    

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GlobalEventManager.SendEnemyKilled(10);
        }
    }

}

