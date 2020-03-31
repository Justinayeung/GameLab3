using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChoices : MonoBehaviour
{
    [Header("References")]
    public GameObject choices;

    public void Start() {
        choices.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            choices.SetActive(true);
        }
    }
}
