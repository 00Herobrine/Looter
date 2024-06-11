using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LooseLootSpawn : LootSpawn
{
    public override void GenerateLoot()
    {
        Vector3 spawnPos = GetRandomPointInBounds(Collider.bounds);
        LootItem lootItem = Pool.GetLootItem();
        float terrainY = GetTerrainHeightAtPosition(spawnPos);
        float adjustedY = terrainY + (lootItem.Item.Prefab.transform.localScale.z * lootItem.Scale / 2);
        Debug.Log($"Got spawnPos({spawnPos}) terrainY({terrainY}) adjustedY({adjustedY})");
        //Debug.Log("Spawning " + lootItem.Item.Name);
        spawnPos.y = adjustedY;
        GameObject spawned = Instantiate(lootItem.Item.Prefab, spawnPos, Quaternion.Euler(lootItem.Rotation), transform);
        spawned.transform.localScale *= lootItem.Scale;
    }
}