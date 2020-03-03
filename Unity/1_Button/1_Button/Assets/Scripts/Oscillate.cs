using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    [Header("Variables")]
    public float time;
    public float speed;
    public float scale;

    void Start() {
        
    }

    void Update() {
        Vector3 zAxis = new Vector3(0, 0, 1); //Declaring zAxis
        transform.RotateAround(new Vector3(0, 0, 0), zAxis, occillate(time, speed, scale));
    }

    private float occillate(float time, float speed, float scale)
    {
        return Mathf.Cos(time * speed/Mathf.PI) * scale; //returns a Cos(angle) * scale of rotation
    }
}
