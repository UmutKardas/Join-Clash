using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimationController : MonoBehaviour
{

    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private Animator bossAnimator;


    void Update()
    {
        BossAttackAnimation();
        BossDeathAnimation();
    }



    private void BossAttackAnimation()
    {
        if (bossDataTransmitter.GetTouchBoss())
        {
            bossAnimator.SetBool("BossAttack", true);
        }
    }



    private void BossDeathAnimation()
    {
        if (bossDataTransmitter.GetBossDeath())
        {
            bossAnimator.SetBool("BossDeath", true);
        }
    }
}
