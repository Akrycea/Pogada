using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    float speedX;
    float speedY;
    public float movSpeed;

    public bool movingUp;
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        movingUp = false;
    }

    
    void Update()
    {
        if (!movingUp)
        {
            Movement();
        }
        else
        {
            MovementUp();
        }


    }

    private void Movement()
    {
        
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rbPlayer.linearVelocity = new Vector2(speedX, 0);
        
    }

    private void MovementUp()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        rbPlayer.linearVelocity = new Vector2(0, speedY);
    }
}
