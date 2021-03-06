﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioSource bounce;

    private float speed;
    private Rigidbody2D rb;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start() {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>(); //Reference to rigidbody2D
    }

    void Update(){
        speed = 8f; //Set speed to 8s
    }

    /// <summary>
    /// Reset ball to original starting point
    /// </summary>
    public void ResetBall() {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }

    /// <summary>
    /// Get a random direction
    /// </summary>
    public void RandomDirection() {
        //conditon ? True : False
        float x = Random.Range(0f, 2f) <= 1 ? -1 : 1;
        float y = Random.Range(0f, 2f) <= 1 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Wall")) { //If ball hits wall or player, play audio
            bounce.pitch = Random.Range(0.65f, 1.15f); //Random audio pitch
            bounce.Play(); //play audio
        }
    }
}
