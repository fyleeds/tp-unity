using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1000;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float maxY, minY;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input
        //Vector2 po = transform.position;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement y = Mathff.Clamp(Pose.y);
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
