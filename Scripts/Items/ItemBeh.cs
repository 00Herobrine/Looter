using Unity.Netcode;
using UnityEngine;

public abstract class ItemBeh<T> : NetworkBehaviour where T : ItemBeh<T>
{

}