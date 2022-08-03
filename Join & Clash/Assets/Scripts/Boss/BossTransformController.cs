using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTransformController : MonoBehaviour
{

    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private GameObject playerGameobject;


    void Update()
    {
        SetBossLook();
    }



    private void SetBossLook()
    {
        if (bossDataTransmitter.GetBossDeath() == false)
        {
            transform.LookAt(playerGameobject.transform);
        }

        else
        {
            transform.LookAt(new Vector3(0, 0, 0));
        }
    }
}
