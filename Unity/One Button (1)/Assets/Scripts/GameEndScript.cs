using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndScript : MonoBehaviour
{
    [Header("Scripts")]
    public GameManager gameMan;
    public FinishLine finishL;

    [Header("Gameobjects")]
    public GameObject LastStageText;

    void Start()
    {
        LastStageText.SetActive(false);
    }

    void Update()
    {
        if (finishL.isFinished && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("stage_2")) {
            LastStageText.SetActive(true);
            gameMan.LastStage();
        }
    }
}
