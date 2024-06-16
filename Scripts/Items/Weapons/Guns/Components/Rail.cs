using System;
using UnityEngine;

public class Rail : ComponentDefinition
{
    [field: SerializeField] public ConnectPoint[] Attached { get; private set; }
    public Rail() : base(ComponentType.Mount) { }
}

[Serializable]
public struct ConnectPoint
{
    [field: SerializeField] public Transform Pos { get; private set; }
    [field: SerializeField] public GunAttachment Attachment { get; private set; }
}