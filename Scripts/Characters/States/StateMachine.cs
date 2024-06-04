using Unity.VisualScripting;

public abstract class StateMachine : IState
{
    protected IState currentState;
    public virtual void Enter() => currentState?.Enter();
    public virtual void Exit() => currentState?.Exit();
    public virtual void Update() => currentState?.Update();
    public virtual void HandleEvent(string eventId) => currentState?.HandleEvent(eventId);
    public void ChangeState(IState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }
}