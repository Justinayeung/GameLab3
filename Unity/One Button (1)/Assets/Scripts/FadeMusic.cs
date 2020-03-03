using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeMusic : MonoBehaviour
{
    private Animator anim;
    public FinishLine finishL;

    public AudioSource audioS;

    public AudioClip BGM;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

        audioS.clip = BGM;
        audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (finishL.isFinished)
        {
            anim.SetTrigger("MusicFade");
        }
    }
}
