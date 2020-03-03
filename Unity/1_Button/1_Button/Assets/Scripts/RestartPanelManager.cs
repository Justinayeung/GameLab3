using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPanelManager : MonoBehaviour
{
    public GameObject RestartPanel;
    public GameObject FinalScore;//final score object
    private GameObject Player;

    public GameObject BGM;

    void Start() {
        RestartPanel.SetActive(false);
        FinalScore.SetActive(false);//final score object on startup
        Player = GameObject.FindGameObjectWithTag("Player");
        BGM = GameObject.FindGameObjectWithTag("BGM");
    }

    void Update() {
        CheckPlayer();
    }

    void CheckPlayer() {
        if (Player == null) { //If player is destroyed, restart
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart() {
        yield return new WaitForSeconds(1.5f);
        RestartPanel.SetActive(true);
        FinalScore.SetActive(true);//final score is displayed
        BGM.SetActive(false);
    }
}
