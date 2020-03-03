using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    //Animation of the player
    private Animator mAnim;
    
    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
        {   
            mAnim.SetBool("IsPressed", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            mAnim.SetBool("IsPressed", false);
        }
    }
}
