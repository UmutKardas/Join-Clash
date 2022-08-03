using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private float mouseXSpeed;
    [SerializeField] private float playerSpeed;
    private Vector3 newPlayerPositionVector;
    private float newMouseX;


    void Update()
    {
        SetPlayerX();
        SetPlayerMovement();
    }



    private void SetPlayerX()
    {
        newMouseX = transform.position.x + playerDataTransmitter.GetMouseX() * mouseXSpeed * Time.deltaTime;
    }



    private void SetPlayerMovement()
    {
        if (playerDataTransmitter.GetIsTouch())
        {
            newPlayerPositionVector = new Vector3(newMouseX, transform.position.y, transform.position.z + playerSpeed * Time.deltaTime);
            transform.position = newPlayerPositionVector;
        }

    }
}
