using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityChange : MonoBehaviour
{
    [Header("References")]
    public GameObject pinkLight;
    public GameObject dayCycle;
    public GameObject nightObj;
    public GameObject dayObj;
    public Light dayLight;

    [Header("Variables")]
    public float min;
    public float max;
    static float t = 0.0f;
    public float speed;
    float timer = 0f;
    float timeChange;

    bool night;

    void Update()
    {
        if (night) {
            nightObj.SetActive(true);
            dayObj.SetActive(false);

            dayLight.enabled = false;
            pinkLight.transform.position = new Vector3(Mathf.Lerp(min, max, t), pinkLight.transform.position.y, pinkLight.transform.position.z);

            t += 0.1f * Time.deltaTime;

            if (t > 1f) {
                float temp = max;
                max = min;
                min = temp;
                t = 0.0f;
                timer += 1;
                timeChange = timer;
            }
        }

        if (!night) {
            nightObj.SetActive(false);
            dayObj.SetActive(true);
            dayLight.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            night = !night;
        }

        if (dayCycle.transform.rotation.x <= 0f && dayCycle.transform.rotation.x >= -70f) {
            night = true;
        } else {
            night = false;
        }

        dayCycle.transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        dayCycle.transform.LookAt(Vector3.zero);

    }
}
