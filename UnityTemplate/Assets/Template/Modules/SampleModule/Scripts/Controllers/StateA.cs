using UnityEngine;

namespace Template
{
    public class StateA : State
    {
        public override void OnStateEnter(StateController stateController)
        {
            base.OnStateEnter(stateController);
            Debug.Log("Enter State A");
        }
        public override void OnStateUpdate()
        {
            base.OnStateUpdate();
            Debug.Log("Update State A");
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
            Debug.Log("Exit State A");
        }

    }
}