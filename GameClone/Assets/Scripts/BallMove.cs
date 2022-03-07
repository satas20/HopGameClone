using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Vector3 mousePos;
    private bool isBeingHeld=false;
    private Vector3 first;
    public Rigidbody rb;
    private void Start()
    {
        
    }
    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            
            transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, 0)/3;
            isBeingHeld = true;
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);

        }

    }
    
       
        
    
    

}
