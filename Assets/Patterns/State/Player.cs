using System;
using System.Collections;
using System.Collections.Generic;
using Patterns.State;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Dictionary<Type, IPlayerBehaviour> behaviorsMap;
    private IPlayerBehaviour behaviorCurrent;

    private void Start()
    {
        InitBehaviors();
        SetBehaviorByDefault();
    }

    private void InitBehaviors()
    {
        behaviorsMap = new Dictionary<Type, IPlayerBehaviour>();
        
        behaviorsMap[typeof(PlayerBehaviourActive)] = new PlayerBehaviourActive();
        behaviorsMap[typeof(PlayerBehaviourAgressive)] = new PlayerBehaviourAgressive();
        behaviorsMap[typeof(PlayerBehaviourIdle)] = new PlayerBehaviourIdle();
        
    }

    private void SetBehavior(IPlayerBehaviour newBehaviour)
    {
        behaviorCurrent?.Exit();

        behaviorCurrent = newBehaviour;
        behaviorCurrent.Enter();

    }

    private void SetBehaviorByDefault()
    {
        SetBehaviorIdle();
    }


    private IPlayerBehaviour GetBehavior<T>() where T: IPlayerBehaviour 
    {
        Type type = typeof(T);
        return behaviorsMap[type];

    }

    private void Update()
    {
        behaviorCurrent?.Update();
    }

    public void SetBehaviorIdle()
    {
        var type = GetBehavior<PlayerBehaviourIdle>();
        SetBehavior(type);
    }
    
    public void SetBehaviorAgressive()
    {
        var type = GetBehavior<PlayerBehaviourAgressive>();
        SetBehavior(type);
    }
    
    public void SetBehaviorActive()
    {
        var type = GetBehavior<PlayerBehaviourActive>();
        SetBehavior(type);
    }
    
}

