using UnityEngine;

public class LootManager : MonoBehaviour {
    private string _lootPrefabsFolder = "LootPrefabs";

    public T GetRandomEnum<T>() {
        System.Array values = System.Enum.GetValues(typeof(T));
        return (T)values.GetValue(Random.Range(0, values.Length));
    }

    public void SpawnItem(Items.LootableItems itemType, Vector3 spawnLocation) {
        GameObject itemPrefab = Resources.Load<GameObject>($"{_lootPrefabsFolder}/{Items.GetItemName(itemType)}");
        Instantiate(itemPrefab, spawnLocation, Quaternion.identity);
    }
}
