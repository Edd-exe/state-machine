using UnityEngine;

public class EnemyAttackState : EnemyState
{
    public EnemyAttackState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        isRootState = true;
    }


    public override void EnterState()
    {

    }

    public override void UpdateState()
    {
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

        if (!context.IsAttacking)
        {
            if (context.IsMoving)
            {
                SwitchStates(factory.Move);
            }
            else
            {
                SwitchStates(factory.Idle);
            }
        }
    }

    public override void InitializeSubState()
    {

    }

    private void Attack()
    {

    }
}
