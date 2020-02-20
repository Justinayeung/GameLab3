using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public FXController fxMan;

    // Start is called before the first frame update
    void Start()  {
        
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < Input.touchCount; i++) {
            //Input.touches[i] //Gives you current touch, accessing it through an array
            Touch touch = Input.GetTouch(i);

            //If screen is tapped than spawn the explosion
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1) {
                fxMan.SpawnExplosion(Camera.main.ScreenToWorldPoint(touch.position)); //This is like a mouse event, translates the point to the world space
            }
        }
    }
}
