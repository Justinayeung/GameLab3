using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class AidManager : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public PostProcessVolume pp;
    Vignette vig;

    // Start is called before the first frame update
    void Start() {
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        pp.profile.TryGetSettings(out vig);
    }

    // Update is called once per frame
    void Update() {
        if (vig.intensity.value > 0.20f) {
            obj1.SetActive(true);
            obj2.SetActive(true);
        }

        if (vig.intensity.value > 0.24f) {
            obj3.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
