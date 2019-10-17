using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    ScoreManager score;
    BallSpawner ballSpawner;

    private void Start()
    {
        score = FindObjectOfType<ScoreManager>();
        ballSpawner = FindObjectOfType<BallSpawner>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("PlayerWall"))
        {
            score.AddScore("ai");
        }
        else if (gameObject.CompareTag("AIWall"))
        {
            score.AddScore("player");
        }

        Destroy(other.gameObject);
        ballSpawner.SpawnBall();
    }
}
