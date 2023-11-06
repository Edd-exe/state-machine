using UnityEngine;

public class EnemyIdleState : EnemyState
{
    public EnemyIdleState(StateMachine stateMachine, StateFactory stateFactory)
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

        if (context.IsAttacking)
        {
            SwitchStates(factory.Attack);
        }
        else if (context.IsMoving)
        {
            SwitchStates(factory.Move);
        }
    }

    public override void InitializeSubState()
    {
 
    }
}
