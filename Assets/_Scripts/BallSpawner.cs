using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] Ball ballPrefab;
    [SerializeField] float spawnDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall()
    {
        StartCoroutine(SpawnBallDelay());
    }

    IEnumerator SpawnBallDelay()
    {
        yield return new WaitForSeconds(spawnDelay);
        Ball ballObject = Instantiate(ballPrefab, new Vector2(transform.position.x, Random.Range(-4f, 4f)), transform.rotation) as Ball;
    }
}
