using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDataTransmitter : MonoBehaviour
{

    [SerializeField] private BossCollisionController bossCollisionController;
    [SerializeField] private BossHealtController bossHealtController;


    public bool GetTouchBoss()
    {
        return bossCollisionController.isBossTouch;
    }



    public bool GetBossDeath()
    {
        return bossHealtController.bossDeath;
    }



    public void GetBossTakenDamage()
    {
        bossHealtController.BossTakenDamage();
    }
}
