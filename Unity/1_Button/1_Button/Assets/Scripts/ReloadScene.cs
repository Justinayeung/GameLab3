using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//restart scene with spacebar
//load game scene by pressing a button on main menu

public class ReloadScene : MonoBehaviour
{
    public static bool playerIsDead;

    // Start is called before the first frame update
    void Start()
    {
        playerIsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsDead) { //Only if player is dead can you restart
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                score.scoreValue = 0;
            }
        }
    }
}
