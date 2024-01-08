using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    public float maxY, minY;
    public float maxX, minX;
    private Rigidbody2D rb;
    private Vector2 movement;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Input
        //
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        // Calculate new position
        Vector2 newPosition = rb.position + movement * Speed * Time.fixedDeltaTime;

        // Clamp the new position to stay within the boundaries
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Move the Rigidbody to the clamped position
        rb.MovePosition(newPosition);

    }

}
