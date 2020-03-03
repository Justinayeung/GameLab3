using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//create overlap circle
public class Overlap : MonoBehaviour
{
    public bool allowCatSpawn;
    public float playerRad;
    
    private GameObject cat;
    private bool hasCat = false;
    public Transform underPlayer; //Position under the player
    public LayerMask catLayer;

    SpawnCats spawn;

    void Start() {
        spawn = FindObjectOfType<SpawnCats>(); //Finding object with script SpawnCats
    }

    // Update is called once per frame
    void Update()
    {
        OverlapCir();
    }

    /// <summary>
    /// Checking if cat is in the overlap Circle or not
    /// </summary>
    void OverlapCir() {
        Collider2D other = Physics2D.OverlapCircle(transform.position, playerRad, catLayer); //Declaring collider other equal to the overlap circle

        if(other) { //If there is a cat touching the circle
            Debug.Log("Cat Player");
            cat = other.gameObject; //setting private gameobject cat to the object the overlapCircle is touching
            cat.transform.position = this.transform.position; //Setting the cat to equal the moving object
            hasCat = true;
        } else { //If there isn't a cat touching the circle
            cat = null;
            hasCat = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasCat){
            spawn.SpawnCat(); //Spawn a new cat
            cat.transform.position = underPlayer.position; //Set's the position to under the right under spawner
        }
    }
}
