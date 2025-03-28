using System.Collections.Generic;
using UnityEngine;

namespace OurUtils
{
    public class StateController
    {
        [SerializeField] State _currentState;

        public State CurrentState { get => _currentState; set => _currentState = value; }

        public void ChangeToState(State newState)
        {
            if (CurrentState.Equals(newState))
            {
                return;
            }
            CurrentState.OnStateExit();
            CurrentState = newState;
            CurrentState.OnStateEnter(this);
        }
    }
}