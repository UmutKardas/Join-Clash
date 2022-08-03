using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Animator bossAnimator;


    void Update()
    {
        SetRunAnimation();
        SetAttackAnimation();
        SetDanceAnimation();
    }



    private void SetRunAnimation()
    {
        if (playerDataTransmitter.GetIsTouch())
        {
            playerAnimator.SetBool("Running", true);
        }

        else
        {
            playerAnimator.SetBool("Running", false);

        }
    }



    private void SetAttackAnimation()
    {
        if (bossAnimator.GetBool("BossAttack") == true && bossDataTransmitter.GetBossDeath() == false)
        {
            playerAnimator.SetBool("PlayerAttack", true);
        }

        else
        {
            playerAnimator.SetBool("PlayerAttack", false);
        }
    }



    private void SetDanceAnimation()
    {
        if (playerDataTransmitter.GetLevelFinish())
        {
            playerAnimator.SetBool("PlayerDance", true);
        }
    }
}
