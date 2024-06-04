using Unity.Netcode;
using UnityEngine;

public class GameManager : SingletonBehavior<GameManager>
{
    [field: Header("Player Settings")]
    [field: SerializeField] public Color FriendlyColor { get; private set; } = Color.blue;
    [field: SerializeField] public Color EnemyColor { get; private set;} = Color.red;
    [field: SerializeField] public LootPool[] LootPools { get; private set; }
    private void Start()
    {
        
    }

    public void GenerateLoot() // Make this a job
    {

    }
    /*    [ServerRpc]
        protected void RequestMoveServerRpc(Vector3 movement, Vector2 look, ServerRpcParams rpcParams = default)
        {
            HandleMovement(movement);
            HandleLook(look);
        }*/
    public static void Move(CharacterController character)
    {
        Vector3 movement = character.movement.normalized * (character.MovementData.WalkSpeed * character.moveSpeed);
        if (!character.IsGrounded) movement *= character.MovementData.AirSpeedMod;
        character.Rigidbody.AddForce(movement, ForceMode.Acceleration);
    }
    public static void SpawnItem(Item itemData, Vector3 position)
    {
        Instantiate(itemData.Prefab, position, Quaternion.identity);
    }
}
