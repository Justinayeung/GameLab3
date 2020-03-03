using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsOnGroundSoundScript : MonoBehaviour
{
    public AudioSource waterSound;
    bool IsOnGround;

    void Start()
    {
        waterSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnGround)
        {
            waterSound.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            IsOnGround = true;
        }
    }
}
