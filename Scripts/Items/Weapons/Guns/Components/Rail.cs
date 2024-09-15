using System;
using UnityEngine;

public class Rail : GunComponentDefinition
{
    [field: SerializeField] public ConnectPoint[] Attached { get; private set; }
    public Rail() : base(ComponentType.Mount) { }
}

[Serializable]
public struct ConnectPoint
{
    [field: SerializeField] public Transform Pos { get; private set; }
    [field: SerializeField] public AttachmentDefinition Attachment { get; private set; }
}