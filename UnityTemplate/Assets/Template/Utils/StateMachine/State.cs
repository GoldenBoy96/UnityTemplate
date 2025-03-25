namespace Template
{
    public abstract class State
    {
        protected StateController stateController;

        public virtual void OnStateEnter(StateController stateController)
        {
            this.stateController = stateController;
        }

        public virtual void OnStateUpdate()
        {
        }

        public virtual void OnStateExit()
        {
        }
    }
}