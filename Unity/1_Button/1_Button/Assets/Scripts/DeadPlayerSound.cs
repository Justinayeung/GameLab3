using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this script plays the sound when the player dies
public class DeadPlayerSound : MonoBehaviour
{

    public AudioClip DeadPlayer;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    ///<summary>
    ///below is the code that plays the sound when the player dies
    ///</summary>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            source.PlayOneShot(DeadPlayer);
            Debug.Log("PlayerDed");
        }
    }
}
