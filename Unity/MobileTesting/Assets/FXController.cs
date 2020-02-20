using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXController : MonoBehaviour
{
    public ParticleSystem exPrefab;

    /// <summary>
    /// Spawns a particle system
    /// </summary>
    /// <param name="pos"></param>
    /// <returns></returns>
    public ParticleSystem SpawnExplosion(Vector3 pos) {
        //Instantiate returns a Gameobject so use as ParticleSystem so that there are no errors (return a ParticleSystem)
        ParticleSystem effect = Instantiate(exPrefab, pos, Quaternion.identity, this.transform) as ParticleSystem;
        Destroy(effect.gameObject, 10f); //You can do effect.main.duration
        return effect;
    }
}
