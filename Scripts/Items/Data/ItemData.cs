using System;
using Unity.Collections;
using UnityEngine;

[Serializable]
public class itemData : IItemData
{
    [field: SerializeField, ReadOnly] public string UUID { get; private set; }
    [field: SerializeField] public string GUID { get; private set; }
    [field: SerializeField] public string OwnerID { get; private set; }
}