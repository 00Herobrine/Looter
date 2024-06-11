using UnityEngine;

public class AbstractAttribute : ScriptableObject
{
    [field: Header("Attribute Info")]
    [field: SerializeField] public string Name { get; private set; }
}