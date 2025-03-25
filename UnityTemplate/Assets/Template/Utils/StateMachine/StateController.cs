using UnityEngine;

namespace Template
{
    public class StateController : MonoBehaviour
    {
        [SerializeField] State currentState;

        void Update()
        {
            currentState?.OnStateUpdate();
        }

        public void ChangeToState(State newState)
        {
            if (currentState.Equals(newState))
            {
                return;
            }
            currentState.OnStateExit();
            currentState = newState;
            currentState.OnStateEnter(this);
        }
    }
}