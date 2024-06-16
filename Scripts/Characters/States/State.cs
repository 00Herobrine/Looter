using UnityEngine;

public abstract class State
{
    bool isComplete;
    float startTime;

    protected Vector2 moveInput;
    protected Vector2 lookInput;

    float time => Time.time - startTime;
    public abstract void Enter();
    public abstract void UpdateState();
    public abstract void Exit();
    public abstract void CheckSwitchStates();
    public abstract void InitializeSubState();

    void UpdateStates() { }
    void SwitchStates() { }
    void SetSuperState() { }
    void SetSubState() { }

}