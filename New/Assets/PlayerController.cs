using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X"));
    }
}
