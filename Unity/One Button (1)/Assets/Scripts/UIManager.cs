using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Scripts")]
    public FinishLine FinishLine;
    public GameManager GameManager;
    public MaxCatManager MaxCatMan;

    [Header("UI Gameobjects")]
    public GameObject VictoryText;
    public GameObject RestartText;

    //UI text
    public Text maxCatText;

    public int minusCat;

    private SpawnCats spawnCats;

    void Start()
    {
        VictoryText.SetActive(false);
        RestartText.SetActive(false);

        //maxCatText = GetComponent<Text>();
        minusCat = 0;
        spawnCats = FindObjectOfType<SpawnCats>();

    }

    void Update()
    {
        VictoryTriggered();

        if (FinishLine.isFinished) {
            //Go to the level
            GameManager.MoveScene();
        }

        if (spawnCats.CatSpawned) { //If the first cat is spawned
            if (Input.GetKeyDown(KeyCode.Space)) {
                if (MaxCatMan.maxCats > MaxCatMan.catCounter) { //Checking if cat counter is less than the limit
                    minusCat++;
                }
            }
        }
        maxCatText.text = "Cats: " + minusCat + "/" + MaxCatMan.maxCats;
    }

    //Victory Text pops up
    //currently repeating
    void VictoryTriggered()
    {
        if (FinishLine.isFinished)
        {
            VictoryText.SetActive(true);
        }
    }

    //accessed by GameManager
    public void RestartTriggered()
    {
        RestartText.SetActive(true);

    }
}
