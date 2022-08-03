using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{

    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerUIController playerUIController;
    [SerializeField] private PlayerHealtController playerHealtController;
    [SerializeField] private PlayerParticleEffect playerParticleEffect;


    public float GetMouseX()
    {
        return playerInputController.mouseX;
    }



    public bool GetIsTouch()
    {
        return playerInputController.isTouch;
    }



    public void GetPlayerDeadUIController()
    {
        playerUIController.SetPlayerDeadUIController();
    }



    public void GetPlayerTakenDamage()
    {
        playerHealtController.PlayerTakenDamage();
    }



    public void GetUILevelFinish()
    {
        playerUIController.SetLevelFinish();
    }



    public bool GetLevelFinish()
    {
        return playerUIController.lvlFinish;
    }



    public void PlayFinishParticleEffectActive()
    {
        playerParticleEffect.PlayFinishParticleEffectActive();
    }
}
