using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CollectAid : MonoBehaviour
{
    [Header("References")]
    public GameObject smoke;
    public PostProcessVolume pp;

    Vignette vig;
    private Vector3 scaleChange;
    private bool once = false;

    public void Start()
    {
        scaleChange = new Vector3(0.2f, 0.2f, 0.2f);
        pp.profile.TryGetSettings(out vig);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !once)
        {
            smoke.transform.localScale -= scaleChange;
            vig.intensity.value -= 0.08f;
            once = true;
        }
    }
}
