using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipX : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    SpriteRenderer sprite;

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Flip1"))
        {
            sprite.flipX = true;
        }
        else if (other.CompareTag("Flip2")) {
            sprite.flipX = false;
        }
    }
}
