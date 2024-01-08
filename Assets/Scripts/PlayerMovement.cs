using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    public float maxY, minY;
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
        movement.y = Mathf.Clamp(movement.y, minY, maxY);

    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }

}
