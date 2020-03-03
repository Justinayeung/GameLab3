using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for the rebound sound effect

public class reboundSound : MonoBehaviour
{
    [Header("Variables")]
    public AudioClip rebound;//audioclip for rebound sound

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame

    ///<summary>
    ///this plays the sound when you bounce off an object
    ///</summary>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Barrier"){
           source.PlayOneShot(rebound);
           Debug.Log("SoundIsPlaying");
        }
    }
}
