public class  VillagerStateFactory : StateFactory
{
    public VillagerStateFactory(StateMachine stateMachine)
    : base(stateMachine)
    {
        //root-states
        _idleState = new(stateMachine, this);
        _moveState = new(stateMachine, this);
        _dieState = new(stateMachine, this);
    }

    #region Fields
    private readonly VillagerIdleState _idleState;
    private readonly VillagerMoveState _moveState;
    private readonly VillagerDieState _dieState;
    #endregion

    #region Properties
    public BaseState Idle { get => _idleState; }
    public BaseState Move { get => _moveState; }
    public BaseState Die { get => _dieState; }
    #endregion
}
