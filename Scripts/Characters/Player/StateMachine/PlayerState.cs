public abstract class PlayerState : BaseState
{
    protected readonly Player context;
    protected readonly PlayerStateFactory factory;

    public PlayerState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        context = (Player)stateMachine;
        factory = (PlayerStateFactory)stateFactory;
    }
}
