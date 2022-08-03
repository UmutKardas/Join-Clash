using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChangeController : MonoBehaviour
{

    [SerializeField] private CinemachineMixingCamera cameraMixing;
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;


    void Update()
    {
        if (playerDataTransmitter.GetLevelFinish() == true)
        {
            cameraMixing.m_Weight0 -= Time.deltaTime;
            cameraMixing.m_Weight1 += Time.deltaTime;
        }
    }
}
