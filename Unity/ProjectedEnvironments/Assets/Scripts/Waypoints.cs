using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float radius = 1f;

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < radius) { //Checks if distance if less than radius
            current = Random.Range(0, waypoints.Length);
            if (current >= waypoints.Length) { //Checks if integer value of current is bigger or = to the last checkpoint
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed); //Moves object towards waypoint
    }
}
