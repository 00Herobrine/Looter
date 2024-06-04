public class KeyBehaviour : AbstractItemBehaviour<KeyItem>
{
    public void UseItem()
    {
        if (ItemData == null) return;
        ItemData.Use();
        //if (ItemData.HP <= 0) DestroyItem();
    }
}