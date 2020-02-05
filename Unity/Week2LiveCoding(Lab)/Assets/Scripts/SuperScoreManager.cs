using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Takes inheritance from scoreManager so you have everything that scoreManager has
//This model isn't the best practice
//Unity has ECS (Entity Componenet System) -- inheritance through functions
//It is better to separate code into different things/methods
//You should never have a separate script for different players
public class SuperScoreManager : ScoreManager
{
    void Start() {
        
    }

    void Update() {
        
    }

    void SuperInscreaseScore() {
        IncreaseScore(5);
        IncreaseScore(5);
        IncreaseScore(5);
    }
}
