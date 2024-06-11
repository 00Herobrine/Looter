using UnityEngine;

public class GunBehaviour : WeaponBehaviour<Gun>
{
    [field: SerializeField] public GunComponent[] Components { get; private set; }
    public GunBehaviour()
    {

    }

    public override void Initialize()
    {
        InitializeComponents();
    }

    protected void InitializeComponents()
    {
        Components = new GunComponent[ItemData.Components.Count];
        int i = 0;
        foreach (GunComponent component in ItemData.Components.Values)
            InitializeComponent(i++, component);
    }

    protected void InitializeComponent(int index, GunComponent component)
    {
        Components[index] = component;
        Instantiate(Components[index].Prefab, transform);
    }
}