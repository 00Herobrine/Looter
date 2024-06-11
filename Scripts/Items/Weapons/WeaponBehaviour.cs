using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public abstract class WeaponBehaviour<T> : AbstractItemBehaviour<T> where T : Weapon<T>
{
    public UnityEvent AttackedEvent { get; private set; }
    public UnityEvent AttackEvent { get; private set; }
    [field: SerializeField] public NetworkVariable<double> LastAttack { get; private set; }

    [ServerRpc]
    public void UpdateLastAttackServerRpc() => LastAttack.Value = Time.timeAsDouble;
}