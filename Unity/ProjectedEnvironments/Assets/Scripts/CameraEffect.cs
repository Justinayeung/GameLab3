using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraEffect : MonoBehaviour
{
    public PostProcessVolume pp;
    ChromaticAberration chrome;
    Vignette vig;
    LensDistortion dis;
    AmbientOcclusion amo;

    public Material[] wallMaterial;
    public Renderer[] walls;
    bool change = false;

    // Start is called before the first frame update
    void Start() {
        pp.profile.TryGetSettings(out chrome);
        pp.profile.TryGetSettings(out vig);
        pp.profile.TryGetSettings(out dis);
        pp.profile.TryGetSettings(out amo);
    }

    // Update is called once per frame
    void Update() {
        chrome.intensity.value = Mathf.PingPong(Time.time * 0.3f, 2);
        vig.intensity.value = Mathf.PingPong(Time.time * 0.2f, 1.5f);
        dis.intensity.value = Mathf.PingPong(Time.time, 60);
        amo.intensity.value = Mathf.PingPong(Time.time, 1);

        if (vig.intensity.value > 1 && !change) {
            for (int i = 0; i < walls.Length - 1; i++) {
                walls[i].material = wallMaterial[Random.Range(0, wallMaterial.Length)];
            }
            change = true;
        }

        if (vig.intensity.value < 0.5f) {
            change = false;
        }
    }
}
