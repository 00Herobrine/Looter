using System;
using UnityEngine;

[CreateAssetMenu(menuName = DefinitionCategories.Health + "/Limb")]
public class LimbDefinition : ScriptableObject, ILimbData
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public float Health { get; private set; }
    [field: SerializeField] public float MaxHealth { get; private set; }
    [field: SerializeField] public bool IsCrucial { get; private set; }
    [field: SerializeField] public bool IsBroken { get; private set; }
    [field: SerializeField] public HealthAttribute[] Attributes { get; private set; }
}