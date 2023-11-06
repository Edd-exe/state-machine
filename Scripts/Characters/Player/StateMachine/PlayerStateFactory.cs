public class PlayerStateFactory : StateFactory
{
    public PlayerStateFactory(StateMachine stateMachine)
    : base(stateMachine)
    {
        //root-states
        _idleState = new(stateMachine, this);
        _moveState = new(stateMachine, this);
        _dieState = new(stateMachine, this);

        //sub-states
        _emptyState = new(stateMachine, this);
        _attackState = new(stateMachine, this);
    }

    #region Fields
    private readonly PlayerIdleState _idleState;
    private readonly PlayerMoveState _moveState;
    private readonly PlayerDieState _dieState;
    private readonly PlayerEmptyState _emptyState;
    private readonly PlayerAttackState _attackState;
    #endregion

    #region Properties
    public BaseState Idle { get => _idleState; }
    public BaseState Move { get => _moveState; }
    public BaseState Die { get => _dieState; }
    public BaseState Empty { get => _emptyState; }
    public BaseState Attack { get => _attackState; }
    #endregion
}
