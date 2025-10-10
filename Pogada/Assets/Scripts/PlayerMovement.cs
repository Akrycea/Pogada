using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    float speedX;
    float speedY;
    public float movSpeed;

    public bool movingUp;
    public bool movingIncline;
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        movingUp = false;
        movingIncline = false;
    }

    
    void Update()
    {
        if (!movingUp && !movingIncline)
        {
            Movement();
        }
        else if (movingIncline)
        {
            MovementIncline();
        }
        else if(movingUp)
        {
            MovementUp();
        }


    }

    private void Movement()
    {
        
         speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
         rbPlayer.linearVelocity = new Vector2(speedX, 0);
        
    }

    private void MovementIncline()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        //mno¿enie/dzielenie speedow pozwala zmieniac k¹t
        rbPlayer.linearVelocity = new Vector2(speedX, speedY);
    }

    private void MovementUp()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        rbPlayer.linearVelocity = new Vector2(0, speedY);
    }
}
