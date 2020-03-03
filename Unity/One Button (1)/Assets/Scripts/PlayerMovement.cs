using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform pos1, pos2;
    [Range(0f, 6f)]
    public float speed;

    public bool gameEnd;

    //global bool for moving
    public bool ismoving;

    void Update()
    {
        if (gameEnd)
        {
            MoveSideToSide(true);
        }
        else {
            MoveSideToSide(false);
        }

    }

    public void MoveSideToSide(bool moving) {
        if (moving == true)
        {
            ismoving = true;
            transform.position = Vector2.Lerp(pos1.transform.position, pos2.transform.position,     //Lerp the player side of side along 
                                             (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);         // x-axis
        } else if (!moving) {
            ismoving = false;
            transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
