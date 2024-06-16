using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Characters/Movement Data")]
public class MovementSO : ScriptableObject
{
    [field: SerializeField] public float WalkSpeed { get; private set; }
    [field: SerializeField] public float RunSpeed { get; private set; }
    [field: SerializeField] public float IdleSpeed { get; private set; }
    [field: SerializeField] public float AirSpeedMod { get; private set; } = 0.2f;
    [field: SerializeField] public float JumpForce { get; private set; } = 5f;
    [field: SerializeField] public float AirDrag { get; private set; } = 1f;
    [field: SerializeField] public float GroundDrag { get; private set; } = 3f;
    [field: SerializeField] public float RotationSpeed { get; private set; } = 1f;
}

[Serializable]
public struct ValueMod
{
    [field: SerializeField] public float Value { get; private set; }
    [field: SerializeField] public float Mod { get; private set; }
    public static implicit operator float(ValueMod vm) => vm.Value * vm.Mod;
}