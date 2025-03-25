using UnityEngine;

namespace Template
{
    public class TemplateController : StateController, IResetState
    {
        //The Controller should be used to control State
        //Logic Handle should be put in each State
        [Header("Init Data")]
        [SerializeField] private TemplateModel _templateModel;

        [Header("Child Component")]
        [SerializeField] private Transform _childComponent;

        [Header("Runtime")]
        [SerializeField] private TemplateModel _runtimeModel;

        [Header("State Machine")]
        [SerializeField] private StateA _stateA = new();
        [SerializeField] private StateB _stateB = new();

        public StateA StateA { get => _stateA; private set => _stateA = value; }
        public StateB StateB { get => _stateB; private set => _stateB = value; }

        public void Reset()
        {
            //TO DO: Reset controller
            ChangeToState(StateA); //Assign default state
        }
    }
}