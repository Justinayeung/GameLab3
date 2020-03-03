using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float initialSize;
    public float zoomSize;
    public float smooth;

    Camera cam;

    void Start() {
        cam = GetComponent<Camera>();
        cam.orthographicSize = initialSize; //Get orthographic size
    }

    void Update() {
        Zoom();
    }

    /// <summary>
    /// Zoom camera when holding down X
    /// </summary>
    public void Zoom() {
        if (Input.GetKey(KeyCode.Space)) {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoomSize, smooth * Time.deltaTime); //Zoom camera in (currentSize(initialSize), to zoomSize, over a period of time)
        } else {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, initialSize, smooth * Time.deltaTime); //Zoom camera out (currentSize(zoomSize), to initalSize, over a period of time)
        }
    }
}
