using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //destroy cat clone when triggered with deathbox
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cat")) {
            Destroy(col.gameObject,2f);
            Debug.Log("Cat hit the bed");
        }
    }
}
