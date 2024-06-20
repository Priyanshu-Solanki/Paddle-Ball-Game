using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    bool started;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        started = false;
    }

    void Update()
    {
        if(Input.anyKeyDown && !started)
        {
            GameManager.instance.GameStart();
            StartBounce();
            started = true;
        }
    }
    void StartBounce()
    {
        float randomNumber = Random.Range(-1, -0.5f);
        Vector2 randomDirection = new Vector2(randomNumber, 1);
        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();
        }
        else if (collision.gameObject.tag == "Paddle")
        {
            GameManager.instance.ScoreUp();
        }
    }
}
