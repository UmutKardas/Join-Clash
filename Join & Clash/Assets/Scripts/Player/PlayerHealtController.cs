using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealtController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    private float playerHealt = 100f;
    private float takenDamage = 1f;


    void Update()
    {
        SetPlayerDead();
    }



    private void SetPlayerDead()
    {
        if (playerHealt <= 0)
        {
            playerDataTransmitter.GetPlayerDeadUIController();
        }
    }



    public void PlayerTakenDamage()
    {
        playerHealt -= takenDamage;
    }
}