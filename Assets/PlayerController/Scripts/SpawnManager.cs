using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // created an array of animalPrefabs
    private float spawnRangeX = 20; // created variable with specific range value 
    private float spawnPosZ = 20; // created variable with specific position  value 
    private float startDelay = 2; // created variable to delay start
    private float spawnInterval = 1.5f; // created variable for interval of spawn
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // repeatedly calling method
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    void SpawnRandomAnimal() //created new custom function
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // created a variable for the animals and a random action of selecting an animal
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // createing random spawn range and position 

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // cloneing original prefab and spawning at random position
    }
}
