using UnityEngine;

namespace Patterns.State
{
    public class PlayerBehaviourAgressive: IPlayerBehaviour
    {
        private int counter = 0;
        public void Enter()
        {
            Debug.Log("Enter Agressive behavior");
        }

        public void Exit()
        {
            Debug.Log("Exit Agressive behavior");
        }

        public void Update()
        {
            counter++;
            Debug.Log("Update Agressive behavior" + counter);
        }
    }
}