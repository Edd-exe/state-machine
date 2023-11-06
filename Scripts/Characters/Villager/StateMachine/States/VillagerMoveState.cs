using UnityEngine;

public class VillagerMoveState : VillagerState
{
    public VillagerMoveState(StateMachine stateMachine, StateFactory stateFactory)
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
