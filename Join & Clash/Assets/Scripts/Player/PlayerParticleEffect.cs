using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticleEffect : MonoBehaviour
{

    [SerializeField] private ParticleSystem fireworksParticleEffect;


    public void PlayFinishParticleEffectActive()
    {
        fireworksParticleEffect.gameObject.SetActive(true);
        fireworksParticleEffect.Play();
    }
}
