using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    private Vector2 movement;
    public float maxY, minY;


    void Update()
    {
        // Input
        Vector2 movement = transform.position;
        movement += new Vector2(0, Speed) *  Input.GetAxisRaw("Vertical") * Time.deltaTime ;
        movement.y = Mathf.Clamp(movement.y, minY, maxY);
        transform.position = movement;
       // movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");
        
    }

}
