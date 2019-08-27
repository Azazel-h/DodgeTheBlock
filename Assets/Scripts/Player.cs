using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 13f;
    public ScoreText score;
    public GameObject character;
    private Rigidbody2D rb;

    void Start()
    {
        rb = character.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            int direction = (touch.position.x > (Screen.width / 2)) ? 1 : -1;
            Move(direction);
        }
    }

    void Update()
    {
        #if UNITY_EDITOR
        float x = Input.GetAxis("Horizontal");
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -5f, 5f);
        rb.MovePosition(newPosition);
        #endif
    }

    void Move(int direction)
    {
        float xPos = (direction * Time.deltaTime * speed);
        Vector2 newPosition = rb.position + Vector2.right * xPos;
        newPosition.x = Mathf.Clamp(newPosition.x, -5f, 5f);
        rb.MovePosition(newPosition);
    }

    void OnTriggerEnter2D()
    {
        score.ScoreUpdate();
    }

    void OnCollisionEnter2D ()
    { 
        FindObjectOfType<GameManager>().EndGame();
    }
}
