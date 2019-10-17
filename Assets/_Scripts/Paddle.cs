using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float paddleVelocity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle();
    }

    void MovePaddle()
    {
        // Get direction
        var verticalAxis = Input.GetAxis("Vertical");
        // Move in that direction with paddle velocity
        Vector3 move = new Vector3(0f, verticalAxis * paddleVelocity * Time.deltaTime, 0f);
        transform.position += move;
        // get new position
        Vector3 newPos = transform.position;
        // dont let go over boundaries
        newPos.y = Mathf.Clamp(newPos.y, -4f, 4f);
        // set new pos
        transform.position = newPos;
    }
}
