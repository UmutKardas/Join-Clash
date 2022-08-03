using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollisionController : MonoBehaviour
{

    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private BossTransformController bossTransformController;
    public bool isBossTouch = false;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("ChildStickman"))
        {
            bossTransformController.enabled = true;
            isBossTouch = true;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerLeftPunch") || other.gameObject.CompareTag("StickmanLeftPunch"))
        {
            bossDataTransmitter.GetBossTakenDamage();
        }
    }
}
