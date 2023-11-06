using UnityEngine;

public class EnemyMoveState : EnemyState
{
    public EnemyMoveState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        isRootState = true;
    }


    public override void EnterState()
    {

    }

    public override void UpdateState()
    {
        Move();
        CheckSwitchState();
    }

    public override void ExitState()
    {

    }

    public override void CheckSwitchState()
    {
        if (context.IsDeath)
        {
            SwitchStates(factory.Die);
            return;
        }

        if (context.IsAttacking)
        {
            SwitchStates(factory.Attack);
        }
        else if (!context.IsMoving)
        {
            SwitchStates(factory.Idle);
        }
    }

    public override void InitializeSubState()
    {

    }

    private void Move()
    {

    }
}
