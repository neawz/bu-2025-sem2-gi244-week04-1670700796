using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // [1] declare a public GameObject array for animal prefabs
    public GameObject[] animalPrefabs;

    // [2] declare a public int variable for animal index for testing instantiation
    public int animalIndex;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update_for_2_3()
    {
        // [3] for testing spawning animals, press S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            // [5] generate a random index for animal prefabs
            animalIndex = Random.Range(0, animalPrefabs.Length);

            // [6] spawn an animal at random position
            Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            // [4] spawn an animal using animal index
            // Instantiate(
            //     animalPrefabs[animalIndex],
            //     new Vector3(0, 0, 20),
            //     animalPrefabs[animalIndex].transform.rotation
            // );

            // [7] spawn an animal at random position
            Instantiate(
                animalPrefabs[animalIndex],
                spawnPos,
                animalPrefabs[animalIndex].transform.rotation
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animalIndex = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(
                animalPrefabs[animalIndex],
                spawnPos,
                animalPrefabs[animalIndex].transform.rotation
            );
        }
    }
}
