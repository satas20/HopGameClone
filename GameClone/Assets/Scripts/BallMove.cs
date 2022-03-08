using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Vector3 mousePos;
    public static bool started ; 
    private Vector3 first;
    public Rigidbody rb;
    private void Start()
    {
        started = false;
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            started = true;
        }
        if (Input.GetMouseButton(0)&&started)
        {
            
            transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, 0)/3;
            
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);

        }

    }
    
       
        
    
    

}
