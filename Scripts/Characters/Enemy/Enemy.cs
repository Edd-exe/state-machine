using UnityEngine;

public class Enemy : StateMachine
{
    #region Fields
    private EnemyStateFactory _state;

    private bool _isMoving = false;
    private bool _isAttacking = false;
    private bool _isDeath = false;
    #endregion

    #region Properties
    public bool IsMoving { get => _isMoving; set => _isMoving = value; }
    public bool IsAttacking { get => _isAttacking; set => _isAttacking = value; }
    public bool IsDeath { get => _isDeath; set => _isDeath = value; }
    #endregion


    #region Main
    private void Start()
    {
        StartState();
    }

    protected override void Update()
    {
        base.Update();
    }
    #endregion

    protected void StartState()
    {
        _state = new(this);
        PlayState(_state.Idle);
    }
}
