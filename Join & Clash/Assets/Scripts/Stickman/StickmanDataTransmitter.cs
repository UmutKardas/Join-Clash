using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanDataTransmitter : MonoBehaviour
{

    [SerializeField] private StickmanCollisionController stickmanCollisionController;
    [SerializeField] private StickmanHealtController stickmanHealtController;
    [SerializeField] private StickmanParticleEffect stickmanParticleEffect;


    public bool GetPlayerTouchStickman()
    {
        return stickmanCollisionController.playerIsTouch;
    }



    public bool GetStickmanTouchStickman()
    {
        return stickmanCollisionController.stickmanIsTouch;
    }



    public void GetStickmanTakenDamage()
    {
        stickmanHealtController.StickmanTakenDamage();
    }



    public void GetBarierDamage()
    {
        stickmanHealtController.SetBarierDamage();

    }



    public void GetDeadParticleEffectActive()
    {
        stickmanParticleEffect.DeadParticleEffectActive();
    }
}
