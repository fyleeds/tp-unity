using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody2D asteroid;
    public float Speed = 2f;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the Rigidbody2D component to the asteroid variable
        asteroid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = -Speed;

    }
    void FixedUpdate()
    {
        // Calculate new position
        Vector2 newPosition = asteroid.position + movement * Speed * Time.fixedDeltaTime;

        // Clamp the new position to stay within the boundaries
        //newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        //newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Move the Rigidbody to the clamped position
        asteroid.MovePosition(newPosition);

    }
}
