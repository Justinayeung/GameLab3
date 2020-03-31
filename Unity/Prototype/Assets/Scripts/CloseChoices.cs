using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CloseChoices : MonoBehaviour
{
    [Header("References")]
    public GameObject choices;
    public GameObject smoke;
    public PostProcessVolume pp;

    Vignette vig;
    private Vector3 scaleChange;

    public void Start() {
        scaleChange = new Vector3(0.2f, 0.2f, 0.2f);
        pp.profile.TryGetSettings(out vig);
    }

    public void Choice1() {
        choices.SetActive(false);
    }

    public void Choice2() {
        smoke.transform.localScale -= scaleChange;
        vig.intensity.value -= 0.08f;
        choices.SetActive(false);
    }

    public void Choice3() {
        smoke.transform.localScale += scaleChange;
        vig.intensity.value += 0.08f;
        choices.SetActive(false);
    }
}
