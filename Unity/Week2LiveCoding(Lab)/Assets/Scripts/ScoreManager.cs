using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    //Comment language stuff:   TODO:, //, /* */, ///

    public int score = 0;

    void Start() {
        int test = 7;
        Debug.Log(Double(test));

        //This is the same as the code above
        int testDoubled = Double(test);
        Debug.Log(testDoubled);

        //String that is a command
        test = OneOrZero("One");
    }

    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space)) {
        //    IncreaseScore();
        //}
    }

    //This function will increase score by a passed amount

    /*
    public void IncreaseScore(int increaseAmt)
    {
        Debug.Log("Increaseing score");
        score += increaseAmt;
    }
    */

    //Most common return type is a bool
    //Allows you to pass a Debug

    /// <summary>
    /// This increases the score by the amount passed.
    /// </summary>
    /// <param name="increaseAmt"></param>
    /// <returns></returns>
    public bool IncreaseScore(int increaseAmt) {
        if (increaseAmt > 0) {
            Debug.Log("Increaseing score");
            score += increaseAmt;
            return true;
        } else {
            return false;
        }
    }

    int Double(int toDouble) {
        //Gives you a number that is doubled
        return toDouble * 2;
    }

    /// <summary>
    /// This returns 1 or 0, depending on string passed to it
    /// </summary>
    /// <param name="thingToReturn"></param> Pass in "One" to get 1 </param>
    /// <returns></returns>
    int OneOrZero(string thingToReturn) {
        if (thingToReturn == "Done") {
            return 1;
        } else {
            return 0;
        }
    }

    public int CheatMode(string cheatCode) {
        Debug.Log("Cheat activated");
        return 1;
    }
}
