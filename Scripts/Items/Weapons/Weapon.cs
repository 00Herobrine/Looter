using Unity.Netcode;
using UnityEngine;

public abstract class Weapon<T> : AbstractItem<T> where T : WeaponData
{
    public bool CanAttack => Time.time - ItemData.LastAttack > ItemData.Cooldown;

    protected virtual void Attack()
    {
        if (IsServer)
        {
           ItemData.LastAttack = Time.time;
        }
    }

    [ServerRpc]
    protected void UpdateLastAttackServerRpc()
    {
        if (!IsServer) return;
        //ItemData.LastAttack = Time.time;
    }
}