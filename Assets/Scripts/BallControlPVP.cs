using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BallControlPVP : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject playerObject;
    public GameObject enemyObject;
    public bool ballIsActive;
    private Vector3 ballPosition;
    private bool enemyBall = false;
    public AudioSource ballSound;
    public float Timer;
    public bool Contact;
    public AudioMixer masterMixer;

    void Start()
    {
        Timer = 12f;
        ballIsActive = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
        {
            Contact = true;
        }
        ballSound.pitch = Random.Range(0.9f, 1.1f);
        ballSound.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (ballIsActive == false)
        {
            masterMixer.SetFloat("BallSound", -80);
        }
        else
        {
            masterMixer.SetFloat("BallSound", 0);
        }
        if (ballIsActive)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                if (Contact == false)
                {
                    ballIsActive = !ballIsActive;
                    ballPosition.x = playerObject.transform.position.x;
                    ballPosition.y = -3.84f;
                    transform.position = ballPosition;
                    Timer = 12f;
                }
                else
                {
                    Timer = 12f;
                    Contact = false;
                }
            }
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (!ballIsActive && (enemyBall == false))
            {
                rb.velocity = new Vector2(6f, 6f);
                ballIsActive = !ballIsActive;
            }
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            if (!ballIsActive && (enemyBall == true))
            {
                rb.velocity = new Vector2(-6f, -6f);
                ballIsActive = !ballIsActive;
                enemyBall = false;
            }
        }
        if (!ballIsActive && playerObject != null && !enemyBall)
        {
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = playerObject.transform.position.y;
            transform.position = ballPosition;
        }
        if (!ballIsActive && playerObject != null && enemyBall)
        {
            ballPosition.x = enemyObject.transform.position.x;
            ballPosition.y = enemyObject.transform.position.y;
            transform.position = ballPosition;
        }  
        if (FindObjectOfType<CountScore>().SpawnPl1 == true)
        {
            ballIsActive = !ballIsActive;
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = playerObject.transform.position.y;
            transform.position = ballPosition;
            FindObjectOfType<CountScore>().SpawnPl1 = false;
        }
        if (FindObjectOfType<CountScore>().SpawnPl2 == true)
        {
            ballIsActive = !ballIsActive;
            ballPosition.x = enemyObject.transform.position.x;
            ballPosition.y = enemyObject.transform.position.y;
            transform.position = ballPosition;
            enemyBall = true;
            FindObjectOfType<CountScore>().SpawnPl2 = false;
        }
    }
}
