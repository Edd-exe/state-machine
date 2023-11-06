using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private BaseState _currentState;

    public BaseState CurrentState { get => _currentState; set => _currentState = value; }

    protected virtual void Update()
    {
        _currentState.UpdateStates();
    }

    protected void PlayState(BaseState state)
    {
        _currentState?.ExitState();
        _currentState = state;
        _currentState.EnterState();
    }
}
