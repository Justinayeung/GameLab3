using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour // this script detects when the cat touches the ground 
{                                // After than it plays the cat animation

    private Animator mAnim;
    private bool IsGround;

    void Start()
    {
        mAnim = GetComponent<Animator>();
        IsGround = false;
    }

    void Update()
    {
        if (IsGround) {
            mAnim.SetBool("IsOnGround", true);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Cat")) {
            IsGround = true;
        }
    }
}
