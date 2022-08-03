using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanHealtController : MonoBehaviour
{

    [SerializeField] private StickmanDataTransmitter stickmanDataTransmitter;
    private float stickmanHealt = 50f;
    private float takenDamage = 8f;


    void Update()
    {
        SetStickmanDead();
    }



    public void SetStickmanDead()
    {
        if (stickmanHealt <= 0)
        {
            gameObject.SetActive(false);
            stickmanDataTransmitter.GetDeadParticleEffectActive();

        }
    }



    public void SetBarierDamage()
    {
        gameObject.SetActive(false);
        stickmanDataTransmitter.GetDeadParticleEffectActive();
    }



    public void StickmanTakenDamage()
    {
        stickmanHealt -= takenDamage;
    }
}
