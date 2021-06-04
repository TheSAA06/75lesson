using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Transform head_tr;

    float MouseX;
    float MouseY;
    public float sens = 3f;
    float v;
    float h;
    Rigidbody rb;
    
    void Start()
    {
        head_tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -40, 40);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");   
        rb.velocity = transform.forward * v * 5f;
    }
}