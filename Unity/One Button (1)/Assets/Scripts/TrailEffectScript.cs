using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffectScript : MonoBehaviour
{
    public TrailRenderer trail;
    private bool Istouched;

    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
    }

    void Update()
    {
        if (Istouched) {
            trail.enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BouncyGround")) {
            Istouched = true;
        }
    }
}
