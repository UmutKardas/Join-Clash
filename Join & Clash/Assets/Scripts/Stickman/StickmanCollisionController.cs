using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanCollisionController : MonoBehaviour
{

    [SerializeField] private StickmanDataTransmitter stickmanDataTransmitter;
    [SerializeField] private GameObject playerGameobject;
    [SerializeField] private GameObject stickmanGameobject;
    private PlayerDataTransmitter playerDataTransmitter;
    public bool playerIsTouch = false;
    public bool stickmanIsTouch = false;


    private void Start()
    {
        playerGameobject = GameObject.FindGameObjectWithTag("Player");
        playerDataTransmitter = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataTransmitter>();
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stickmanGameobject.transform.parent = playerGameobject.transform;
            gameObject.tag = "ChildStickman";
            playerIsTouch = true;

        }

        else if (other.gameObject.CompareTag("ChildStickman"))
        {
            stickmanGameobject.transform.parent = playerGameobject.transform;
            gameObject.tag = "ChildStickman";
            stickmanIsTouch = true;
        }


        if (other.gameObject.CompareTag("Barrier"))
        {
            stickmanDataTransmitter.GetBarierDamage();
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
            stickmanDataTransmitter.GetStickmanTakenDamage();
        }

    }
}
