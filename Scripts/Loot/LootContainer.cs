using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Collider))]
public class LootContainer : LootSpawn, IInteractable, IContainer<ItemObject[]>
{
    [field: Header("Container Refs")]
    [field: SerializeField] public Animator Animator { get; private set; }
    public int defaultHash { get; private set; }
    public int lidOpenHash { get; private set; }
    public int lidCloseHash { get; private set; }
    [field: Header("Container Info")]
    [field: SerializeField] public float Radius { get; private set; }
    [field: SerializeField] public float MaxLidAngle { get; private set; } = 60f;
    [field: SerializeField] public float OpenTime { get; private set; } = 2f;
    [field: SerializeField] public AnimationCurve SpeedRamp { get; private set; }
    [field: SerializeField] public MinMax Range { get; private set; }
    [field: SerializeField] public Vector2Int Size { get; private set; }
    [field: SerializeField] public ItemObject[] Items { get; private set; }
    [field: SerializeField] public bool Opened { get; private set; }
    [field: SerializeField] public bool IsLidMoving { get; private set; }

    private void Awake()
    {
        defaultHash = Animator.StringToHash("Default");
        lidOpenHash = Animator.StringToHash("Lid_Open");
        lidCloseHash = Animator.StringToHash("Lid_Close");
    }

    private void Update()
    {
        OpeningCheck();
        if(InputSystem.actions.FindAction("Jump").triggered)
        {
            ToggleOpen();
        }
    }

    public void OpeningCheck()
    {
        AnimatorStateInfo info = Animator.GetCurrentAnimatorStateInfo(0);
        IsLidMoving = info.shortNameHash != defaultHash; // playing an anim
    }

    private void ToggleOpen()
    {
        if (IsLidMoving) return;
        if (!Opened) OpenLid();
        else CloseLid();
    }

    public void Open(Character character)
    {
        // if receieved contents from server open instantly else
        // Display searching UI then load contents once received
        // if(ReceivedContents(character)) character.OpenInventory(this);
        // else RequestContentsAndOpen(character);
        if (character.transform.position.sqrMagnitude > Radius) return;
        OpenLid();
    }

    protected void OpenLid()
    {
        if (Opened) return;
        Animator.Play(lidOpenHash);
        Opened = true;
    }

    protected void CloseLid()
    {
        if(!Opened) return;
        Animator.Play(lidCloseHash);
        Opened = false;
    }

    public void Close()
    {

    }

    [ServerRpc]
    public override void GenerateLootServerRpc()
    {
        int items = Random.Range(Range.Min, Range.Max);
        Items = new ItemObject[Size.x * Size.y];
        for (int i = 0; i < items; i++)
        {
            LootItem lootItem = Pool.GetLootItem();
            Items[i] = lootItem.Item;
        }
    }
}

public interface IInteractable
{
    float Radius { get; }
}