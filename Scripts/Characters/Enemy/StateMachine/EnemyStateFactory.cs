public class EnemyStateFactory : StateFactory
{
    public EnemyStateFactory(StateMachine stateMachine) 
    : base(stateMachine) 
    {
        //root-states
        _idleState = new(stateMachine, this);
        _moveState = new(stateMachine, this);
        _dieState = new(stateMachine, this);
        _attackState = new(stateMachine, this);
    }

    #region Fields
    private readonly EnemyIdleState _idleState;
    private readonly EnemyMoveState _moveState;
    private readonly EnemyDieState _dieState;
    private readonly EnemyAttackState _attackState;
    #endregion

    #region Properties
    public BaseState Idle { get => _idleState; }
    public BaseState Move { get => _moveState; }
    public BaseState Die { get => _dieState; }
    public BaseState Attack { get => _attackState; }
    #endregion
}
