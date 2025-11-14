using UnityEngine;
using UnityEngine.InputSystem;


public class PLayerMovement : MonoBehaviour
{
    // FEATURE LIST
    // 1. Use arrow key for movement 
    // 2. need a variable for speed
    // 3. We need to store the direction of our character
    // 4. need a variable for running
    // 5. speical movement example: rolling or dashing
    // 6. Mantling
    // 7. If we can climb or not

    private float moveSpeed = 5f;
    private Rigidbody2D rb;


    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

}
