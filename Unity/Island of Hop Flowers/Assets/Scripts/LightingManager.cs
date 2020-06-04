using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LightingManager : MonoBehaviour
{
    [Header ("References")]
    [SerializeField] private Light directionalLight;
    [SerializeField] private LightingPreset preset;

    [Header ("Variables")]
    [SerializeField, Range(0, 24)] private float timeOfDay;

    public void Update() {
        if (preset == null) { //Check if preset is assigned
            return;
        }

        if (Application.isPlaying) { //If application is playing, update time and lighting
            timeOfDay += Time.deltaTime;
            timeOfDay %= 24; //Clamp between 0-24
            UpdateLighting(timeOfDay / 24f);
        } else {
            UpdateLighting(timeOfDay / 24f);
        }
    }

    /// <summary>
    /// Method for changing lighting settings based on the time of day, evaluates preset variables based on the time
    /// </summary>
    /// <param name="timePercent"></param>
    public void UpdateLighting(float timePercent) {
        RenderSettings.ambientLight = preset.AmbientColor.Evaluate(timePercent);
        RenderSettings.fogColor = preset.FogColor.Evaluate(timePercent);

        if (directionalLight != null) { //Changing directional light rotation
            directionalLight.color = preset.DirectionalColor.Evaluate(timePercent);
            directionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));
        }
    }

    //OnValidate = a function that is called when the script is loaded or a value is changed in the inspector
    /// <summary>
    /// Check is we haven't set up or directional light, set it to whichever directional light is the sun in the scene
    /// </summary>
    public void OnValidate() { 
        if (directionalLight != null) { //Check if directional light is assigned
            return;
        }

        if (RenderSettings.sun != null) {
            directionalLight = RenderSettings.sun;
        } else {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach (Light light in lights) { //If we didn't set that variable, search the scene for the first directional light
                if (light.type == LightType.Directional) {
                    directionalLight = light;
                    return;
                }
            }
        }
    }
}
