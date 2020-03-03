using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Scripts")]
    public SpawnCats spawn;
    public PlayerMovement plMov;
    public PlayerMovement chick;
    public MaxCatManager maxCat;
    public UIManager uiMan;

    void Start()
    {
        
    }

    
    void Update()
    {
        plMov.MoveSideToSide(true);
        chick.MoveSideToSide(true);
        //SpawnACat();

        //restart scene, stop functions
        if (maxCat.catCounter >= maxCat.maxCats) {
            Debug.Log("catCounter = maxCat");
            uiMan.RestartTriggered(); //UI pop indicating press space to restart
            plMov.MoveSideToSide(false); //this isn't working ; _;
            spawn.spawning = false;  //no more cats to spawn
            StartCoroutine(WaitThenRestartScene()); //will restart scene
        } 
    }


    //public void SpawnACat() {

    //    spawn.SpawnCat();
    //}

    public void RestartGame() {
        plMov.MoveSideToSide(true);
        chick.MoveSideToSide(true);
    }

    public void GameEnd()
    {
        //when the number of cats is used up, the game ends
        plMov.MoveSideToSide(false);
        chick.MoveSideToSide(false);
    }

    //player is on the last stage and has won, option to go back to menu
    public void LastStage() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("Menu");
        }

    }

    //player has won, next scene automatically
    public void MoveScene() {
        Debug.Log("Waiting 3 seconds..");
        StartCoroutine(WaitThenNextScene());
    }

    //next scene function, wait 3 seconds
    IEnumerator WaitThenNextScene() {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //wait to restart scene with space
    IEnumerator WaitThenRestartScene()
    {
        yield return new WaitForSeconds(1.5f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

