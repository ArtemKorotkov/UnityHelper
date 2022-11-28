using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    [Header("Press A S D Buttons")]
    public Player player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.SetBehaviorActive();
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.SetBehaviorAgressive();
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.SetBehaviorIdle();
        }

    }
}
