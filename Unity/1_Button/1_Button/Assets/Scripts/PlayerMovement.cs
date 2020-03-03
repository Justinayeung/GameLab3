using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("References")]
    public Transform arrowDirection;

    [Header("Variables")]
    [Tooltip("Player's speed")]
    public float speed;
    [Tooltip("Arrow's rotation speed")]
    public float rotationSpeed;

   
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        PlayerMove();
    }

    /// <summary>
    /// Checks if X is pressed, in order for player to move
    /// </summary>
    /// <returns></returns>
    public bool PlayerMove() {
        if (Input.GetKey(KeyCode.Space)) {  //If Space is pressed
            //ArrowRotation(); //Rotate arrow
            PlayerRotation();
            rb.velocity = rb.velocity * 0.9f; //set rb velocity to 0 over time
            return true;
        } else {  //If Space isn't pressed 
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse); //Force is added in the direction of arrow
            return false;
        }
    }

    /// <summary>
    /// Rotation of arrow around player
    /// </summary>
    [ContextMenu("Rotate Arrow")]
    void ArrowRotation() {
        Vector3 zAxis = new Vector3(0, 0, 1); //Declaring Vector3 axis for RotateAround(Vector3 point, Vector3 axis, float angle)
        arrowDirection.RotateAround(transform.position, zAxis, -rotationSpeed); //Rotating arrow around player
    }

    /// <summary>
    /// Rotation of the player
    /// </summary>
    void PlayerRotation() {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }


    /// <summary>
    /// this is 4 score
    /// </summary>
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Points") {
            score.scoreValue += 1;
            Destroy(other.gameObject);
            Debug.Log("score");
        }
    }
}
