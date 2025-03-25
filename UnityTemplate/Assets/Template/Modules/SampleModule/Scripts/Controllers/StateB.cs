using UnityEngine;

namespace Template
{
    public class StateB : State
    {
        public override void OnStateEnter(StateController stateController)
        {
            base.OnStateEnter(stateController);
            Debug.Log("Enter State B");
        }
        public override void OnStateUpdate()
        {
            base.OnStateUpdate();
            Debug.Log("Update State B");
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
            Debug.Log("Exit State B");
        }

    }
}