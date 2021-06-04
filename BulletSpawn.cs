using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    


    GameObject clone;
    Rigidbody clone_rb;
    public GameObject bullet;
    void Start()
    {

        clone_rb = GetComponent<Rigidbody>();
    }
    void Update()
    {       
        

        if(Input.GetMouseButton(0))
        {            
            clone = Instantiate(bullet, transform.position, Quaternion.Euler(90f+transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0));
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.velocity(transform.forward * 1600f);
        }
    }
}