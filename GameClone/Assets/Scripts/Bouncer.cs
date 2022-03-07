using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public Rigidbody rb;
    public float bouncerate=150;
    public float speed=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        bounce();
    }
    private void bounce() 
    {
        rb.AddForce(0, bouncerate, 0);
    }
}
