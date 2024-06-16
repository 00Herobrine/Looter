using AYellowpaper.SerializedCollections;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [field: SerializeField] public SerializedDictionary<string, TextMeshProUGUI> Texts { get; private set; }
    InventoryData Inventory;

    private void Start()
    {
        
    }
    public void UpdateText(string key, string value)
    {
        if (Texts.TryGetValue(key, out TextMeshProUGUI text))
            text.text = value;
    }
}