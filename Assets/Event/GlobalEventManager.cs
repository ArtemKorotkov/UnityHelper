
using System;
using UnityEngine.Events;

public class GlobalEventManager
    {

    public static UnityEvent<int> OnEnemyKilled = new UnityEvent<int>();
   

    public static void SendEnemyKilled(int count)
    {
        OnEnemyKilled.Invoke(count);
    }

    }

