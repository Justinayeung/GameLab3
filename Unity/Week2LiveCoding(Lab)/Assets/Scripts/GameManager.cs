using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Scripts / Game Manager")] //Put it in the add component menu in the editor
[SelectionBase] //Makes it so that when you select an object(child) it will select the root parent player
public class GameManager : MonoBehaviour
{
    [ContextMenuItem("Get a random time", "PickRandomGameLength")] //Right click to call the function
    [Header("Important Game Variables")]
    [Tooltip("This is the game length")]
    [Range(0, 100f)] //Range will not clamp the value but in the hierarchy there will be a slider 
    public float gameLength; //Length of game in seconds;

    //[Space(50)]  //To add a gap between headers and variables
    [Header("References to Other Scripts")]
    public ScoreManager scoreManager;

    //Hide what is public
    [HideInInspector]
    public float animDuration = 10f;

    //Show what is private
    [SerializeField]
    private float playerHealth;

    [Tooltip("This is the player's name")]
    public string plName;

    #region Initializing

    void Start() {
        //This is a bad practice because you can lose track of this easily
        //scoreManager.score++;
        scoreManager.IncreaseScore(5);

        if (scoreManager.IncreaseScore(5)) {
            //do something else;
        }
    }

    void Update() {

    }

    #endregion

    //Lets you run something without hitting play
    [ContextMenu("Randomize time")] //Only in front of functions and gets called when you click on the gear in the editor
    public void PickRandomGameLength() {
        gameLength = Random.Range(0f, 100f);
    }
}
