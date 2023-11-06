public abstract class VillagerState : BaseState
{
    protected readonly Villager context;
    protected readonly VillagerStateFactory factory;

    public VillagerState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        context = (Villager)stateMachine;
        factory = (VillagerStateFactory)stateFactory;
    }
}
