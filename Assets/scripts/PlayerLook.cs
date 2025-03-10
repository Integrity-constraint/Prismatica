using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
   
    private float xSensitivity = 30f;
    private float ySensitivity = 30f;


    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mousey = input.y;
        xRotation -= (mousey * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);

    }
}
