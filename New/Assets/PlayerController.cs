 using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
 
public class PlayerController : MonoBehaviour 
{ 
    [SerializeField] Transform cameraHolder;
    [SerializeField] float mouseSensitivity = 1; 
    float verticalLookRotation; 
    float horisontalLookRotation; 

    void Start() 
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
 
    void Update() 
    { 
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity); 
         
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
        horisontalLookRotation += Input.GetAxisRaw("Mouse X") * mouseSensitivity; 
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        horisontalLookRotation = Mathf.Clamp(horisontalLookRotation, -90f, 90f); 
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, horisontalLookRotation, 0); 
    } 
} 
