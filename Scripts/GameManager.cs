using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : SingletonBehavior<GameManager>
{
    [field: Header("Player Settings")]
    [field: SerializeField] public Color FriendlyColor { get; private set; } = Color.blue;
    [field: SerializeField] public Color EnemyColor { get; private set;} = Color.red;
    [field: SerializeField] public LootSpawn[] LootSpawns { get; private set; }
    [field: SerializeField] public ForceMode ForceMode { get; private set; }
    public float GroundSphereSize { get; internal set; } = 0.1f;
    public float LootSphereRadius { get; internal set; } = 2;
    [field: SerializeField] public MovementSO MovementData { get; private set; }

    protected override void Awake()
    {
        //NetworkManager.Singleton.OnClientConnectedCallback
        base.Awake();
        GenerateLoot();
    }

    private void Update()
    {
        if(InputSystem.actions.FindAction("Jump").triggered) GenerateLoot();
    }

    private void GenerateLoot()
    {
        foreach(LootSpawn lootSpawn in LootSpawns)
        {
            lootSpawn.GenerateLootServerRpc();
        }
    }
}
