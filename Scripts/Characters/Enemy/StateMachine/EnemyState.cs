public abstract class EnemyState : BaseState
{
    protected readonly Enemy context;
    protected readonly EnemyStateFactory factory;

    public EnemyState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        context = (Enemy)stateMachine;
        factory = (EnemyStateFactory)stateFactory;
    }
}
