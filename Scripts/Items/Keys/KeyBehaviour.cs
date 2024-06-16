public class KeyBehaviour : AbstractItemBehaviour<KeyData>
{
    public void UseItem()
    {
        if (ItemData == null) return;
        ItemData.Uses--;
        //ItemData.Use();
        //if (ItemData.HP <= 0) DestroyItem();
    }
}

public class KeyData : ItemData
{
    public int Uses { get; set; }
}