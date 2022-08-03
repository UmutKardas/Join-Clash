using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            playerDataTransmitter.GetPlayerDeadUIController();
        }

        if (other.gameObject.CompareTag("Castle"))
        {
            playerDataTransmitter.GetUILevelFinish();
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BossRightFoot"))
        {
            playerDataTransmitter.GetPlayerTakenDamage();
        }

    }
}
