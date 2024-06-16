using System;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public abstract class AbilityEffect
{
    [Tooltip("Delay in Second(s) before activating")]
    public float Delay = 0f;
    public abstract Task Apply(Character owner);
    public virtual bool IsValidTarget() => true;
}