using UnityEngine;

public class AttributeDefinition : ScriptableObject
{
    [field: Header("Attribute Info")]
    [field: SerializeField] public string Name { get; private set; }
}