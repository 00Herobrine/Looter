using System;
using UnityEngine;

[Serializable]
public class CartridgeData : ItemData
{
    [field: SerializeField] public string ProjectileUUID { get; set; }
    [field: SerializeField] public ProjectileData ProjectileData { get; set; }

    public CartridgeData(string uuid) : base(uuid)
    {
        CartridgeDefinition definition = ItemManager.Instance.GetDefinition<CartridgeDefinition>(uuid);
    }
}