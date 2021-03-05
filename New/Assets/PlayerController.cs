using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
 
public class PlayerController : MonoBehaviour 
{ 
    [SerializeField] Transform cameraHolder; 
    float verticalLookRotation; 
    float horisontalLookRotation; 
      
 
    void Update() 
    { 
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X")); 
         
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y");
        horisontalLookRotation += Input.GetAxisRaw("Mouse X"); 
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        horisontalLookRotation = Mathf.Clamp(horisontalLookRotation, -90f, 90f); 
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, horisontalLookRotation, 0); 
    } 
} 
