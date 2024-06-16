using System;
using UnityEngine;

[Serializable]
public class CharacterHealthData
{
    [field: SerializeField] public LimbData[] Limbs { get; protected set; }
}
