using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class florcheck : MonoBehaviour
{
    public Animator animatior;
    private Animation anim;
    private bool animstart;
    private float yk;
    // Start is called before the first frame update
    void Start()
    {
        animstart = false;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.localScale);
        if (transform.localScale.y < 0.5&& animstart)
        {
           
            transform.localScale+= new Vector3(0, 2,0) *Time.deltaTime;
            //yk += Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //anim = this.GetComponent<Animation>();
        //this.animatior.SetBool("bounced",true);
        animstart = true;
    }
}
