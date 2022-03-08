using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bouncer : MonoBehaviour
{
    public Rigidbody rb;
    public float bouncerate=150;
    public float speed=1;
    public GameObject flor;
    public Vector3 spawnpoint;
    private float zk;
    private float time;
    private bool bouncing;
    private float randomum;
    public Text score;
    private int puan=0;
         
    // Start is called before the first frame update
    void Start()
    {
        zk = 1.4F;
        randomum = 0;
        spawnpoint = new Vector3(randomum,0,zk);
        spawn();
        spawn();
        spawn();
        spawn();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = puan.ToString();
        if (BallMove.started) 
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
            rb.useGravity = true;

        }
        // rb.velocity = new Vector3(0, rb.velocity.y, speed);
        time += Time.deltaTime;
        if (Time.timeScale < 4) {
            Time.timeScale += 0.05f * Time.deltaTime;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(transform.position);
        bounce();
        Debug.Log(time);
    }
    private void bounce() 
    {
        
        rb.velocity=new Vector3(0, bouncerate, 0);
        puan++;
        


        spawn();

    }
    private void spawn() 
    {
        float randomum = Random.Range(-2.0F, 2.0F);
        spawnpoint = new Vector3(randomum, 0, zk);
        Instantiate(flor, spawnpoint, Quaternion.identity);
        zk += 1.019492F * speed;
    }
}
