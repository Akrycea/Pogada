using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    float speedX;
    public float movSpeed;
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rbPlayer.linearVelocity = new Vector2(speedX, 0);
        
    }
}
