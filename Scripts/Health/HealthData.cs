using System;
using UnityEngine;

[Serializable]
public class HealthData
{
    [field: SerializeField] public LimbData[] Limbs { get; protected set; }
}
