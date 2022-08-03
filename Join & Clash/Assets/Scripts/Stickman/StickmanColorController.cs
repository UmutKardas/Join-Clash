using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanColorController : MonoBehaviour
{

    [SerializeField] private StickmanDataTransmitter stickmanDataTransmitter;
    [SerializeField] private Material playerMaterial;


    private void Update()
    {
        SetStickmanColor();
    }



    public void SetStickmanColor()
    {
        if (stickmanDataTransmitter.GetPlayerTouchStickman() || stickmanDataTransmitter.GetStickmanTouchStickman())
        {
            gameObject.GetComponent<SkinnedMeshRenderer>().material = playerMaterial;
        }
    }
}
