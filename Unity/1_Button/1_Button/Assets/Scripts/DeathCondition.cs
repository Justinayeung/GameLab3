using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for when the player hits a blade
public class DeathCondition : MonoBehaviour
{
    public static bool playerIsDead;
    public GameObject playerExplosion;
    void Start() {

    }

    ///<summary>
    ///below is everything that happens when a player dies after hittting a blade
    ///</summary>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Blades")) {
            Instantiate(playerExplosion, transform.position, Quaternion.identity); //When it triggers gameobject named Blades, player explodes
            ReloadScene.playerIsDead = true;
            Destroy(gameObject);
            Debug.Log("DeadPlayer");
        }
    }
}
