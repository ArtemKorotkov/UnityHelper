using UnityEngine;

namespace Patterns.State
{
    public class PlayerBehaviourIdle : IPlayerBehaviour
    {
        private int counter = 0;
        public void Enter()
        {
            Debug.Log("Enter Idle behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Idle behavior");
        }

        public void Update()
        {
            counter++;
            Debug.Log("Update Idle behavior"+ counter++);
        }
    }
}