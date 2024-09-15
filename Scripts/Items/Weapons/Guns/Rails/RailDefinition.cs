using JetBrains.Annotations;
using UnityEngine;

public enum RailType
{
    Picatinny, Dovetail, MLOK, KeyMod, Weaver 
}
public class RailDefinition : ItemDefinition
{
    [field: SerializeField] public int Slots { get; protected set; }
    public RailDefinition() : base(ItemType.Rail) 
    { 

    }
}