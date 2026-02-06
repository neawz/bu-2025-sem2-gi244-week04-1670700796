using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float x = Random.Range(-10, 11);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            if (animalPrefabs[animalIndex] != null)
            {
                Instantiate(animalPrefabs[animalIndex], new Vector3(x, 0, 20), Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Debug.LogWarning("Null prefab at index " + animalIndex);
            }
        }
    }
}
