using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Engine")]
public class EngineDefinition : ScriptableObject
{
    [field: SerializeField] public float RPM { get; private set; }
    [field: SerializeField] public float Force { get; private set; }
    [field: SerializeField] public AnimationCurve EfficiencyCurve { get; private set; }
}