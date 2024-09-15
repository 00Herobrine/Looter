using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Type")]
public class DefinitionType : ScriptableObject
{
    [field: SerializeField] public string UUID { get; protected set; } = Guid.NewGuid().ToString();
}