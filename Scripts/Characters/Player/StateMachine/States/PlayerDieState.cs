using UnityEngine;

public class PlayerDieState : PlayerState
{
    public PlayerDieState(StateMachine stateMachine, StateFactory stateFactory)
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
        CheckSwitchState();
    }

    public override void ExitState()
    {

    }

    public override void CheckSwitchState()
    {
        if (!context.IsDeath)
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
        SetSubState(factory.Empty);
    }
}
