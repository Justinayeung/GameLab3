using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBounce : MonoBehaviour
{
    [Range(0f, 100f)]
    public float thrust;

    public Rigidbody2D rb;

    public AudioSource bounceSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bounceSound = GetComponent<AudioSource>();
    }

    //cat jumps in air when touching deathbox
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("DeathBox"))
        {
            Debug.Log("Cat is Death");
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BouncyGround")) {
            bounceSound.Play();
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}
