using UnityEngine;

public class PlayerAttackState : PlayerState
{
    public PlayerAttackState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory) { }


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
        if (!context.IsAttacking)
        {
            SwitchStates(factory.Empty);
        }
    }

    public override void InitializeSubState()
    {

    }
    private void Attack()
    {

    }
}
