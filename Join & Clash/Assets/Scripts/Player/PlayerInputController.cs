using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    public float mouseX;
    public bool isTouch = false;

    void Update()
    {
        SetPlayerTouch();
    }



    private void SetPlayerTouch()
    {
        if (Input.GetMouseButton(0))
        {
            isTouch = true;
            mouseX = Input.GetAxis("Mouse X");
        }

        else
        {
            isTouch = false;
            mouseX = 0;
        }
    }
}
