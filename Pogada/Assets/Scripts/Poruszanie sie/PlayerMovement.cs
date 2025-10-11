using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    float speedX;
    float speedY;
    public float movSpeed;
    private Vector2 newVelocity;

    private int facingDirection = 1;

    private CapsuleCollider2D capsuleColldier;
    private Vector2 colliderSize;
    private Vector2 slopeNormalPerp;
    [SerializeField] private float slopeCheckDistance;
    private float slopeDownAngle;
    private float slopeDownAngleOld;
    private float slopeSideAngle;
    private bool isOnSlope;
    [SerializeField] private PhysicsMaterial2D noFriction;
    [SerializeField] private PhysicsMaterial2D fullFriction;



    private float groundCheckRadius;
    [SerializeField]private Transform groundCheck;
    [SerializeField]private LayerMask whatIsGround;
    private bool isGrounded;

    public bool movingUp;
    public bool movingIncline;
    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        rbPlayer.constraints = RigidbodyConstraints2D.FreezeRotation;

        capsuleColldier = GetComponent<CapsuleCollider2D>();
        colliderSize = capsuleColldier.size;

        movingUp = false;
        movingIncline = false;
    }

    private void FixedUpdate()
    {
        SlopeCheck();
        CheckGround();
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

    private void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void Movement()
    {

        if (isGrounded && !isOnSlope)
        {
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rbPlayer.linearVelocity = new Vector2(speedX, 0.0f);
        }
        else if (isGrounded && isOnSlope)
        {
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rbPlayer.linearVelocity = new Vector2(slopeNormalPerp.x * -speedX, slopeNormalPerp.y * -speedX);
        }
        else if (!isGrounded)
        {
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rbPlayer.linearVelocity = new Vector2(speedX, 0);
        }

        if (speedX == 1 && facingDirection == -1)
        {
            Flip();
        }
        else if (speedX == -1 && facingDirection == 1)
        {
            Flip();
        }

    }

    private void Flip()
    {
        facingDirection *= -1;
        rbPlayer.transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    private void SlopeCheck()
    {
        Vector2 checkPos = transform.position - new Vector3(0.0f, colliderSize.y / 2);

        SlopeCheckHorizontal(checkPos);
        SlopeCheckVerical(checkPos);
    }

    private void SlopeCheckHorizontal(Vector2 checkPos)
    {
        RaycastHit2D slopeHitFront = Physics2D.Raycast(checkPos, transform.right, slopeCheckDistance, whatIsGround);
        RaycastHit2D slopeHitBack = Physics2D.Raycast(checkPos, -transform.right, slopeCheckDistance, whatIsGround);

        if (slopeHitFront)
        {
            isOnSlope = true;
            slopeSideAngle = Vector2.Angle(slopeHitFront.normal, Vector2.up);
        }
        else if (slopeHitBack)
        {
            isOnSlope = true;
            slopeSideAngle = Vector2.Angle(slopeHitBack.normal, Vector2.up);
        }
        else
        {
            slopeSideAngle = 0.0f;
            isOnSlope = false;
        }
    }

    private void SlopeCheckVerical(Vector2 checkPos)
    {
        RaycastHit2D hit = Physics2D.Raycast(checkPos, Vector2.down, slopeCheckDistance, whatIsGround);
        if (hit)
        {
            slopeNormalPerp = Vector2.Perpendicular(hit.normal);

            slopeDownAngle = Vector2.Angle(hit.normal, Vector2.up);

            if(slopeDownAngle != slopeDownAngleOld)
            {
                isOnSlope = true;
            }

            slopeDownAngleOld = slopeDownAngle;

            Debug.DrawRay(hit.point, slopeNormalPerp, Color.red);
            Debug.DrawRay(hit.point, hit.normal, Color.green);
        }

        //if(isOnSlope && speedX == 0.0f)
        //{
        //    rbPlayer.sharedMaterial = fullFriction;
        //}
        //else
        //{
        //    rbPlayer.sharedMaterial = noFriction;
        //}
    }

    private void MovementUp()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        rbPlayer.linearVelocity = new Vector2(0, speedY);
    }
}
