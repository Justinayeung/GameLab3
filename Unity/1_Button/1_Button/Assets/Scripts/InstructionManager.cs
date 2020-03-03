using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionManager : MonoBehaviour
{
    public static bool newPlayer;
    public GameObject instructionPanel;

    void Start() {
        
    }

    void Update() {
        CheckBool();
    }

    /// <summary>
    /// Checks the static bool newPlayer (MainMenu.newPlayer)
    /// </summary>
    void CheckBool() {
        if (MainMenu.newPlayer) { //If newPlayer is true
            instructionPanel.SetActive(true); //Show instructions
            StartCoroutine(InstructionTime());
        } else {
            instructionPanel.SetActive(false);
        }
    }

    /// <summary>
    /// Make the bool (newPlayer) false after a certain amount of time
    /// </summary>
    /// <returns></returns>
    IEnumerator InstructionTime() {
        yield return new WaitForSeconds(3f);
        MainMenu.newPlayer = false;
    }
}
