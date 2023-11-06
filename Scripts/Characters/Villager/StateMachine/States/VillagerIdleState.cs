using UnityEngine;

public class VillagerIdleState : VillagerState
{
    public VillagerIdleState(StateMachine stateMachine, StateFactory stateFactory)
    : base(stateMachine, stateFactory)
    {
        isRootState = true;
    }


    public override void EnterState()
    {
        InitializeSubState();
    }

    public override void UpdateState()
    {
        CheckMoving();
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
        }
        else if (context.IsMoving)
        {
            SwitchStates(factory.Move);
        }
    }

    public override void InitializeSubState()
    {

    }

    private void CheckMoving()
    {

    }
}
