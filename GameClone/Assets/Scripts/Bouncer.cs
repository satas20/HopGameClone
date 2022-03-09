using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    private int flornumber = 0;
    public AudioSource audio;
    public Text text;
    public GameObject gameoverScreen;

    public GameObject addScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        audio = GetComponent<AudioSource>();
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
            transform.Rotate(0,0,1f,Space.Self);
            rb.useGravity = true;

        }
        // rb.velocity = new Vector3(0, rb.velocity.y, speed);
        time += Time.deltaTime;
        if (Time.timeScale < 4  ) {
            Time.timeScale += 0.05f * Time.deltaTime;
        }
        if (transform.position.y < -2) 
        {
            gameover();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(transform.position);
        bounce();
    }
    private void bounce() 
    {
        
        rb.velocity=new Vector3(0, bouncerate, 0);
        puan++;

        audio.pitch += 0.1f * Time.deltaTime; 
        audio.Play();
        spawn();

    }
    private void spawn() 
    {
        flornumber++;
        float randomum = Random.Range(-2.0F, 2.0F);
        if(flornumber > 3)
        {
            spawnpoint = new Vector3(randomum, 2, zk);

        }
        else 
        {
            spawnpoint = new Vector3(randomum, 0, zk);

        }
        Instantiate(flor, spawnpoint, Quaternion.identity);
        zk += 1.019492F * speed;
    }
    private void gameover()
    {
        gameoverScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void addbutton()
    {
        Time.timeScale = 1;

        addScreen.SetActive(false);
    }
    public void restartbutton() 
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("SampleScene");
    }
}
