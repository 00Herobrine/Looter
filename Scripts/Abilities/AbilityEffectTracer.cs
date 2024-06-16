using System;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class AbilityEffectTracer : AbilityEffect
{
    [Tooltip("Duration in Second(s) to Trace attached object")]
    public float Duration = 0f;
    public Color Color = Color.red;
    public LineRenderer lineRenderer;

    public override Task Apply(Character owner)
    {
        return Task.CompletedTask;
    }
}