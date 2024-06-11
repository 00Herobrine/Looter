using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class LootSpawn : MonoBehaviour
{
    [field: Header("Loot Spawn Info")]
    [field: SerializeField] public string PoolID { get; private set; } = $"Pool_{System.Guid.NewGuid().ToString().Split("-")[^1]}";
    [field: SerializeField] public Collider Collider { get; private set; }
    [field: SerializeField] public LootPool Pool { get; private set; }

    public abstract void GenerateLoot();

    protected float GetTerrainHeightAtPosition(Vector3 position)
    {
        // Raycast downwards from a high point to find the terrain
        Ray ray = new Ray(position + (Vector3.up * 20f), Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 50f, LayerMask.GetMask("Environment", "Terrain")))
        {
            Debug.Log($"Raycast hit {hit.collider.gameObject.name} at {hit.point}");
            return hit.point.y;
        }
        // Default to original y position if terrain is not found
        Debug.LogWarning("Raycast did not hit terrain or environment.");
        return position.y;
    }

    protected Vector3 GetRandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            bounds.min.y, // We'll adjust the y-coordinate based on terrain height
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        CharController controller = other.gameObject.GetComponent<CharController>();
        if (controller == null) return;
        // Access Popup
    }
}