using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    // Variables to assign the object you want to spawn and the spawn area limits
    public GameObject objectToSpawn;  // Assign your grabbable object prefab in the Inspector
    public int numberOfObjects = 2;  // The number of objects to spawn
    public Vector3 spawnAreaMin;  // Minimum boundary of the spawn area
    public Vector3 spawnAreaMax;  // Maximum boundary of the spawn area

    // Start is called before the first frame update
    void Start()
    {
        // Spawn the objects when the game starts
        SpawnObjects();
    }

    // Method to spawn objects
    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Generate a random position within the defined area
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            // Instantiate the object at the random position
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
    }

    // Optional: If you want to visualize the spawn area in the editor
    private void OnDrawGizmosSelected()
    {
        // Draw a wireframe cube to show the spawn area
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube((spawnAreaMin + spawnAreaMax) / 2, spawnAreaMax - spawnAreaMin);
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    // Variables to assign the object you want to spawn and the spawn area limits
    public GameObject objectToSpawn;  // Assign your grabbable object prefab in the Inspector
    public int numberOfObjects = 2;  // The number of objects to spawn
    public Vector3 spawnAreaMin;  // Minimum boundary of the spawn area
    public Vector3 spawnAreaMax;  // Maximum boundary of the spawn area

    // Start is called before the first frame update
    void Start()
    {
        // Spawn the objects when the game starts
        SpawnObjects();
    }

    // Method to spawn objects
    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Generate a random position within the defined area
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            // Instantiate the object at the random position
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
    }

    // Optional: If you want to visualize the spawn area in the editor
    private void OnDrawGizmosSelected()
    {
        // Draw a wireframe cube to show the spawn area
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube((spawnAreaMin + spawnAreaMax) / 2, spawnAreaMax - spawnAreaMin);
    }
}
*/