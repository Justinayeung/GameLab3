using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCats : MonoBehaviour
{
    [Header("Prefabs in Array")]
    public GameObject[] maxCat;

    //public GameObject cats;
    [Tooltip("Player's Position")]
    public Transform plPos;

    [Tooltip("MaxManager for Stage")]
    public MaxCatManager MaxCatMan;

    //[HideInInspector]
    public GameObject heartParticles;

    public bool spawning = true;

    public AudioSource catSpawnSound;
    public bool CatSpawned;

    private void Start()
    {
        CatSpawned = false;
        catSpawnSound = GetComponent<AudioSource>();
        StartCoroutine(SpawnBeginningCat()); //Spawn the first cat into the scene
    }

    /// <summary>
    /// When player presses a spacebar, it spawns a cat (This script use to go to GameManager) NOW its to Overlap
    /// </summary>
    public void SpawnCat() {
        if (spawning) {
            catSpawnSound.Play();

            // when you press space spawn a cat
            Vector3 spawnPos = new Vector3(plPos.transform.position.x, plPos.transform.position.y, plPos.transform.position.z);
            Instantiate(maxCat[Random.Range(0, maxCat.Length)], spawnPos, Quaternion.identity);

            // instantiate heart particles
            Vector3 heartPos = new Vector3(plPos.transform.position.x, plPos.transform.position.y - 0.5f, plPos.transform.position.z);
            Instantiate(heartParticles, heartPos, Quaternion.identity);

            MaxCatMan.CatNumUp();
        }
    }

    /// <summary>
    /// Spawns a after a certain time at a position
    /// </summary>
    IEnumerator SpawnBeginningCat() {
        yield return new WaitForSeconds(1f);
        Vector3 spawnPos = new Vector3(plPos.transform.position.x, plPos.transform.position.y + 0.5f, plPos.transform.position.z);
        Instantiate(maxCat[Random.Range(0, maxCat.Length)], spawnPos, Quaternion.identity); //Instantiate a random cat
        CatSpawned = true;
    }
}

