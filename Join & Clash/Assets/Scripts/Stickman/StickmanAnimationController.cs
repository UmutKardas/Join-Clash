using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanAnimationController : MonoBehaviour
{

    [SerializeField] private StickmanDataTransmitter stickmanDataTransmitter;
    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private Animator stickmanAnimator;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Animator bossAnimator;


    private void Start()
    {
        playerAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        bossAnimator = GameObject.FindGameObjectWithTag("Boss").GetComponent<Animator>();
        bossDataTransmitter = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossDataTransmitter>();
    }



    void Update()
    {
        SetRunAnimation();
        SetAttackAnimation();
        SetDanceAnimation();
    }



    private void SetRunAnimation()
    {
        if (playerAnimator.GetBool("Running") == true)
        {
            if (stickmanDataTransmitter.GetPlayerTouchStickman() || stickmanDataTransmitter.GetStickmanTouchStickman())
            {
                stickmanAnimator.SetBool("RunningStickman", true);
            }
        }

        else
        {
            stickmanAnimator.SetBool("RunningStickman", false);
        }
    }



    private void SetAttackAnimation()
    {
        if (bossAnimator.GetBool("BossAttack") == true && bossDataTransmitter.GetBossDeath() == false)
        {
            stickmanAnimator.SetBool("AttackStickman", true);
        }

        else
        {
            stickmanAnimator.SetBool("AttackStickman", false);
        }
    }



    private void SetDanceAnimation()
    {
        if (playerAnimator.GetBool("PlayerDance") == true)
        {
            stickmanAnimator.SetBool("DanceStickman", true);
        }
    }
}
