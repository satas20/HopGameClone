using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class florcheck : MonoBehaviour
{
    public Animator animatior;
    private Animation anim;
    private bool animstart;
    private float yk;
    private GameObject ball;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = 0;
        animstart = false;
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        distance = ball.transform.position.z - transform.position.z;
        if (distance > 10) 
        {
            Destroy(gameObject);    
        }
        if (transform.localScale.y < 0.5&& animstart)
        {
           
            transform.localScale+= new Vector3(0, 2,0) *Time.deltaTime;
            //yk += Time.deltaTime;
        }
        if (transform.position.y > 0) 
        {
            transform.position -= new Vector3(0,5,0)*Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //anim = this.GetComponent<Animation>();
        //this.animatior.SetBool("bounced",true);
        animstart = true;
    }
}
