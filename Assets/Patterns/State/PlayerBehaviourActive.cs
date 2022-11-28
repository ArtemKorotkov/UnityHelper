using UnityEngine;

namespace Patterns.State
{
    public class PlayerBehaviourActive: IPlayerBehaviour
    {
        private int counter = 0;
        public void Enter()
        {
            Debug.Log("Enter Active behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Active behavior");
        }

        public void Update()
        {
            counter++;
            Debug.Log("Update Active behavior" + counter);
        }
    }
}