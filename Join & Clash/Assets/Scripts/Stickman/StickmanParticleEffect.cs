using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanParticleEffect : MonoBehaviour
{

    [SerializeField] private ParticleSystem stickmanParticleEffect;
    [SerializeField] private GameObject stickmanGameobject;


    void Update()
    {
        FallowStickmanPosition();
    }



    private void FallowStickmanPosition()
    {
        transform.position = stickmanGameobject.transform.position;
    }



    public void DeadParticleEffectActive()
    {
        stickmanParticleEffect.gameObject.SetActive(true);
        stickmanParticleEffect.Play();
    }
}
