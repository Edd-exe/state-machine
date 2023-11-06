public abstract class StateFactory 
{
    protected readonly StateMachine context;

    public StateFactory(StateMachine stateMachine)
    {
        context = stateMachine;
    }
}
