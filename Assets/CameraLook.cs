using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    private float xVal = 0;
    private float yVal = 0;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        xVal += Input.GetAxis("Mouse X") * Time.deltaTime * 250;
        yVal += Input.GetAxis("Mouse Y") * Time.deltaTime * 250;

        transform.eulerAngles = new Vector3(-yVal, xVal);
    }
}
