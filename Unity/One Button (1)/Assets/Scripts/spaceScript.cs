using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceScript : MonoBehaviour
{
    public GameManager gameMan;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //calling function from game manager, music fades
        if (Input.GetKeyDown(KeyCode.Space)) {
            gameMan.MoveScene();
            anim.SetTrigger("musicFade");
            
        }
    }
}
