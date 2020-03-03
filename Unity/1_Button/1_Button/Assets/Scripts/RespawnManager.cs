using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [Header("Blade")]
    public GameObject[] BladeTypes;
    public GameObject[] blades;
    
    [Header("Pickup")]
    public GameObject Pickup;

    [Header("Platform")]
    public GameObject Platform;
    public int numberOfPlatforms;

    [Header("Spawn Range X")]
    public float minX;
    public float maxX;

    [Header("Spawn Range Y")]
    public float minY;
    public float maxY;

    [Header("Time")]
    private bool canSpawn; //Can spawn blades
    public float betweenSpawnBlades; //Time between spawning blades
    public float betweenSpawnPickups; //Time between spawning pickups
    private float bladeTime; //Time that counts down 
    private float pickupTime; //Time that counds down

    void Start() {
        canSpawn = false;
        SpawnBouncePlatforms();
    }

    void Update() {
        CheckBladeAmount();
        SpawnBlades();
        SpawnPickups();
    }

    /// <summary>
    /// Checks how many "Blades" are in the scene
    /// </summary>
    void CheckBladeAmount() {
        blades = GameObject.FindGameObjectsWithTag("Blades"); //Finds object with tag 

        if (blades.Length > 39) { //If there are >39 blades
            canSpawn = true;
        }
    }

    /// <summary>
    /// Spawns blade at a random location
    /// </summary>
    void SpawnBlades() {
        if (!canSpawn) { //If can spawn
            bladeTime -= Time.deltaTime; //Decrease blade time
            if (bladeTime <= 0) {
                Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)); //Defining random x,y position
                Instantiate(BladeTypes[Random.Range(0, 2)], pos, Quaternion.identity);
                bladeTime = betweenSpawnBlades; //Set time back to time between spawns
            }
        }
    }

    /// <summary>
    /// Spawns pickups at a random location
    /// </summary>
    void SpawnPickups() {
        pickupTime -= Time.deltaTime; //Decrease pickup time
        if (pickupTime <= 0) {
            Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)); //Defining random x,y position
            Instantiate(Pickup, pos, Quaternion.identity);
            pickupTime = betweenSpawnPickups; //Set the time back to the time between spawns
        }
    }

    /// <summary>
    /// Spawn platforms at a random location and rotation 
    /// </summary>
    void SpawnBouncePlatforms() {
        for (int i = 0; i < numberOfPlatforms; i++) {
            Vector3 euler = transform.eulerAngles;
            euler.z = Random.Range(0f, 360f);
            Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)); //Defining random x,y position
            Instantiate(Platform, pos, Quaternion.Euler(0, 0, euler.z)); //Instantiate at random position and rotation
        }
    }
}
