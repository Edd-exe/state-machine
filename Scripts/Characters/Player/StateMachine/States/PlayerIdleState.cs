using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(StateMachine stateMachine, StateFactory stateFactory) 
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
        else if(context.IsMoving)
        {
            SwitchStates(factory.Move);
        }
    }

    public override void InitializeSubState()
    {
        if (context.IsAttacking) 
        { 
            SetSubState(factory.Attack);
        }
        else
        {
            SetSubState(factory.Empty);
        }
    }

    private void CheckMoving()
    {

    }
}
