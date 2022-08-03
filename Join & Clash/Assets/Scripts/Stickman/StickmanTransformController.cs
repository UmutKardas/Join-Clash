using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanTransformController : MonoBehaviour
{

    [SerializeField] private BossDataTransmitter bossDataTransmitter;
    [SerializeField] private GameObject Castle;
    private GameObject boss;


    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("Boss");
        bossDataTransmitter = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossDataTransmitter>();
        Castle = GameObject.FindGameObjectWithTag("Castle");
    }



    void Update()
    {
        SetStickmanLook();
    }



    private void SetStickmanLook()
    {
        if (bossDataTransmitter.GetBossDeath() == false)
        {
            transform.LookAt(boss.transform);
        }

        else
        {
            transform.LookAt(Castle.transform);
        }

    }
}
