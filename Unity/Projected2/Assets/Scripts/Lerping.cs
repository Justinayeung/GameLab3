using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    public float min;
    public float max;
    static float t = 0.0f;

    void Update() {
        transform.position = new Vector3(Mathf.Lerp(min, max, t), this.transform.position.y, this.transform.position.z);

        t += 0.2f * Time.deltaTime;

        if (t > 1f) {
            float temp = max;
            max = min;
            min = temp;
            t = 0.0f;
        }
    }
}
