using System;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class AbilityEffectTracer : AbilityEffect
{
    [Tooltip("Duration in Second(s) to Trace attached object")]
    [field: SerializeField] public float Duration { get; private set; } = 0f;
    [field: SerializeField] public Color Color { get; private set; } = Color.red;
    [field: SerializeField] public LineRenderer lineRenderer { get; private set; }

    public override Task Apply(Character owner)
    {
        return Task.CompletedTask;
    }
}