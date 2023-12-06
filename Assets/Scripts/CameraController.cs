using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float sensitivity = 5.0f;

    void OnApplicationFocus(bool focusStatus) 
    {
        if (focusStatus)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);
    }
}
