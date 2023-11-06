using UnityEngine;

public class PlayerEmptyState : PlayerState
{
    public PlayerEmptyState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory) {   }


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
        if (context.IsAttacking)
        {
            SwitchStates(factory.Attack);
        }
    }

    public override void InitializeSubState()
    {

    }
}
