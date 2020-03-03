using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [Range(0f, 5f)]
    public float triggerCountdown;

    bool isAtFinishLine = false;

    [Tooltip("This bool triggers Victory Text when true")]
    public bool isFinished = false;

    void Start()
    {
        
    }

    void Update()
    {
        //Countdown after cat collision with finishline
        if (isAtFinishLine == true) {
            
            triggerCountdown -= Time.deltaTime;
            if (triggerCountdown < 0) {
                triggerCountdown = 0;

                isFinished = true;

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //countdown is triggered 
        if (col.gameObject.CompareTag("Cat")) {
            Debug.Log("Cat Collided");
            if (!isAtFinishLine) {
                Debug.Log("Countdown started");
                isAtFinishLine = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        //once cat has left collider, reset triggerCountdown
        if (col.gameObject.CompareTag("Cat")) {
            Debug.Log("Cat is out of the bag");
            isAtFinishLine = false;
            triggerCountdown = 3;
        }      
    }
}
