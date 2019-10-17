using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocity = 1f;
    [SerializeField] float collideForce = 1f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2((Random.Range(0, 2)*2-1) * velocity, Random.Range(-4f, 4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        rb.AddForce(new Vector2(0f, Random.Range((Random.Range(0, 2) * 2 - 1) * collideForce, collideForce)), ForceMode2D.Impulse);
    }
}
