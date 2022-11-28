using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testevent : MonoBehaviour
{

    private int Killed;
    
    private void Awake()
    {
        GlobalEventManager.OnEnemyKilled.AddListener(EnemyKilled);
    }

    public void EnemyKilled(int a)
    {
        Killed++;
        print("Killed" + Killed + a);
    }
    
}
