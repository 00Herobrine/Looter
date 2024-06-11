using UnityEngine;

public abstract class CharacterState
{
    bool isComplete;
    float startTime;

    protected CharController controller;
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

    public CharacterState(CharController controller)
    {
        this.controller = controller;
        startTime = Time.time;
    }
}