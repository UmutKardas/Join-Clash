using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealtController : MonoBehaviour
{

    [SerializeField] private Collider bossCollider;
    [SerializeField] private Animator bossAnimator;
    private float bossHealt = 50f;
    private float takenDamage = 3f;
    public bool bossDeath = false;


    void Update()
    {
        SetBossDead();
    }



    private void SetBossDead()
    {
        if (bossHealt <= 0)
        {
            bossDeath = true;
            bossAnimator.applyRootMotion = true;
            bossCollider.isTrigger = true;
        }

    }



    public void BossTakenDamage()
    {
        bossHealt -= takenDamage;

    }
}
