using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxCatManager : MonoBehaviour
{
    public int maxCats;
    public int catCounter = 0;

    void Start()
    {
        
    }

    void Update()
    {

    }

    //keep track of how many instantiates of cats there are
    public void CatNumUp() {
        Debug.Log(catCounter);
        catCounter++;
    }
}

