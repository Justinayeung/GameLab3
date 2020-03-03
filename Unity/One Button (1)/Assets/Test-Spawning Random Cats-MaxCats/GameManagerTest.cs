using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerTest : MonoBehaviour
{
    public SpawnManagerTest spawn;
    public PlayerMovement plMov;

    void Start()
    {

    }


    void Update()
    {
        SpawnACat();
    }


    public void SpawnACat()
    {
        spawn.SpawnCat();
    }

    public void RestartGame()
    {
        plMov.MoveSideToSide(true);
    }

    public void GameEnd()
    {
        //when the number of cats is used up, the game ends
        plMov.MoveSideToSide(false);
    }

    public void MoveScene()
    {
        Debug.Log("Waiting 2 seconds..");
        StartCoroutine(WaitThenNextScene());
    }

    IEnumerator WaitThenNextScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
