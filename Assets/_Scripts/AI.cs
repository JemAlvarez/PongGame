using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] float paddleVelocity = 1f;
    Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveAI();
    }

    void MoveAI()
    {
        if (!ball)
        {
            ball = FindObjectOfType<Ball>();
            return;
        }

        var direction = ball.GetComponent<Rigidbody2D>().velocity;

        if (direction.x < 0)
        {
            // Move in ball direction with paddle velocity
            if (ball.transform.position.y < transform.position.y)
            {
                transform.position += new Vector3(0f, -paddleVelocity * Time.deltaTime, 0f);
            }

            if (ball.transform.position.y > transform.position.y)
            {
                transform.position += new Vector3(0f, paddleVelocity * Time.deltaTime, 0f);
            }


            // get new position
            Vector3 newPos = transform.position;
            // dont let go over boundaries
            newPos.y = Mathf.Clamp(newPos.y, -4f, 4f);
            // set new pos
            transform.position = newPos;
        }
    }
}
