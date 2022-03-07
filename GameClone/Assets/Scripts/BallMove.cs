using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Vector3 mousePos;
    private bool isBeingHeld=false;
    private Vector3 first;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (isBeingHeld) 
        {
            //this.gameObject.transform.localPosition += 
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            first = mousePos ;
        }

        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            transform.position += new Vector3((mousePos - first).x, 0, 0)/10;
            isBeingHeld = true;

        }
        if(Input.GetMouseButtonUp(0)) 
        {
            Debug.Log("saldý");
            isBeingHeld = false;
        }

    }
    
       
        
    
    

}
