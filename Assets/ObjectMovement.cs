using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float movementValueX = 1.0f;

    Rigidbody2D Obstacle;
    // Start is called before the first frame update
    void Start()
    {
        Obstacle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Obstacle.velocity = new Vector2(movementValueX, Obstacle.velocity.y);
    }
}
