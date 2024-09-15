using Unity.Netcode;
using UnityEngine;

public abstract class AbstractWeaponBehaviour<T> : AbstractItemBehaviour<T> where T : WeaponData
{
    public bool CanAttack => Time.time - ItemData.LastAttack > ItemData.Cooldown;

    protected virtual bool Attack()
    {
        if (IsOwner)
        {
            if (CanAttack)
            {
                UpdateLastAttackServerRpc();
                return true;
            }
        }
        return false;
    }

    [ServerRpc]
    protected void UpdateLastAttackServerRpc()
    {
        if (!IsServer) return;
        ItemData.LastAttack = Time.time;
    }
}