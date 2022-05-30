using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float mouseSensivility = 80;
    public Transform playerbody;
    float xRotation = 0;
    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
