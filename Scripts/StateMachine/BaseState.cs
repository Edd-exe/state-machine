public abstract class BaseState
{
    private readonly StateMachine _context;
    private readonly StateFactory _factory;
    private BaseState _currentSubState;
    private BaseState _currentSuperState;
    
    protected bool isRootState = false;

    public BaseState(StateMachine stateMachine, StateFactory stateFactory)
    {
        _context = stateMachine;
        _factory = stateFactory;
    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    public abstract void CheckSwitchState();
    public abstract void InitializeSubState();


    public void UpdateStates()
    {
        UpdateState();
        _currentSubState?.UpdateStates();
    }

    public void SwitchStates(BaseState newState)
    {
        ExitState();
        newState.EnterState();

        if (isRootState)
        {
            _context.CurrentState = newState;
        }
        else
        {
            _currentSuperState?.SetSubState(newState);
        }
    }

    public void SetSuperState(BaseState newSuperState)
    {
        _currentSuperState = newSuperState;
    }

    public void SetSubState(BaseState newSubState)
    {
        _currentSubState = newSubState;
        newSubState.SetSuperState(this);
    }

    // public void ExitStates()
    // {
    //     ExitState();
    //     if (currentSubState != null)
    //     {
    //         currentSubState.ExitStates();
    //     }
    // }
}
