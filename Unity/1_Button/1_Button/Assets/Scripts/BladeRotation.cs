using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeRotation : MonoBehaviour
{
    public float speed;

    void Update() {
        transform.Rotate(Vector3.forward * speed); //Rotate along zAxis (Vector3.forward = Vector3(0, 0, 1))
    }
}
