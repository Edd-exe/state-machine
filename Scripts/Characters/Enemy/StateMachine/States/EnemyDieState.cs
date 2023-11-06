using UnityEngine;

public class EnemyDieState : EnemyState
{
    public EnemyDieState(StateMachine stateMachine, StateFactory stateFactory)
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
        if (!context.IsDeath)
        {
            if (context.IsAttacking)
            {
                SwitchStates(factory.Attack);
            }
            else if (context.IsMoving)
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
}
