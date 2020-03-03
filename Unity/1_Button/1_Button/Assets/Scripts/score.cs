using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<Text>();
    }

    // Update is called once per frame

    /// <summary>
    /// this updates the on screen score
    /// </summary>
    void Update()
    {
        scoreTxt.text = "Score: " + scoreValue;
    }
}
