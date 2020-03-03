using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTest : MonoBehaviour
{
    [Header("Prefabs in Array")]
    public GameObject[] maxCat;

    //public GameObject cats;
    [Tooltip("Player's Position")]
    public Transform plPos;


    /// <summary>
    /// When player presses a spacebar, it spawns a cat (This script goes to GameManager)
    /// </summary>
    public void SpawnCat()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   // when you press space spawn a cat
            Instantiate(maxCat[Random.Range(0, maxCat.Length)], plPos.transform.position, Quaternion.identity);

        }
    }
}

