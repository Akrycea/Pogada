using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    //deklaracje do chodzenia
    private Rigidbody2D rbPlayer;
    float speedX;
    float speedY;
    public float movSpeed;
    private Vector2 newVelocity;

    private int facingDirection = 1;

    //deklaracje do chodzenia pod gore
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

    public bool movingUp;
    public bool movingIncline;

    //deklaracja do czy mozna chodzic
    [SerializeField]private float groundCheckRadius;
    [SerializeField]private Transform groundCheck;
    [SerializeField]private LayerMask whatIsGround;
    private bool isGrounded;

    
    //deklaracje do animacji i zmiany koloru animacji
    private Animator animator;
    public ColorChange colorChange;
    void Start()
    {
        //to pozniej gdzie indziej przeniesc ale to musi byc kiedys wywolywane poki co
        colorChange.szary = true;

        rbPlayer = GetComponent<Rigidbody2D>();
        rbPlayer.constraints = RigidbodyConstraints2D.FreezeRotation;

        capsuleColldier = GetComponent<CapsuleCollider2D>();
        colliderSize = capsuleColldier.size;

        movingUp = false;
        movingIncline = false;

        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        SlopeCheck();
        CheckGround();
    }
    void Update()
    {

       Movement();

    }

    //sprawdza czy dotyka ziemi, tak = zbiera info fizyki
    private void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void Movement()
    {
        //sprawdza czy jest pod gore i zmienia speed zaleznie od tego
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


        //odwraca postac zaleznie od tego w ktora strone idzie
        if (speedX > 0 && facingDirection == -1)
        {
            Flip();
        }
        else if (speedX < 0 && facingDirection == 1)
        {
            Flip();
        }


        //odpala odpowiednia animacje podczas chodzenia
        if (speedX != 0)
        {
            //za pomoca ColorChange animacja ma odpowiednie kolory
            if (colorChange.szary == true)
            {
                animator.Play("WalkCycle0");
            }
            else if (colorChange.zielony == true)
            {
                animator.Play("WalkCycle1");
            }
            else if (colorChange.czerwony == true)
            {
                animator.Play("WalkCycle2");
            }
            else if (colorChange.granat == true)
            {
                animator.Play("WalkCycle3");
            }
            else if (colorChange.pomarancz == true)
            {
                animator.Play("WalkCycle4");
            }
            else if (colorChange.niebieski == true)
            {
                animator.Play("WalkCycle5");
            }
            else if (colorChange.fiolet == true)
            {
                animator.Play("WalkCycle6");
            }
            else if (colorChange.zolty == true)
            {
                animator.Play("WalkCycle7");
            }
        }
        else
        {
            //za pomoca ColorChange animacja ma odpowiednie kolory
            if (colorChange.szary == true)
            {
                animator.Play("Idle0");
            }
            else if (colorChange.zielony == true)
            {
                animator.Play("Idle1");
            }
            else if (colorChange.czerwony == true)
            {
                animator.Play("Idle2");
            }
            else if (colorChange.granat == true)
            {
                animator.Play("Idle3");
            }
            else if (colorChange.pomarancz == true)
            {
                animator.Play("Idle4");
            }
            else if (colorChange.niebieski == true)
            {
                animator.Play("Idle5");
            }
            else if (colorChange.fiolet == true)
            {
                animator.Play("Idle6");
            }
            else if (colorChange.zolty == true)
            {
                animator.Play("Idle7");
            }
        }

    }

    //odwraca postac
    private void Flip()
    {
        facingDirection *= -1;
        rbPlayer.transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    //sprawdza czy postac idzie pod gore
    private void SlopeCheck()
    {
        Vector2 checkPos = transform.position - new Vector3(0.0f, colliderSize.y / 2);

        SlopeCheckHorizontal(checkPos);
        SlopeCheckVerical(checkPos);
    }

    //sprawia ze postac idzie pod gore
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
            slopeNormalPerp = Vector2.Perpendicular(hit.normal).normalized;

            slopeDownAngle = Vector2.Angle(hit.normal, Vector2.up);

            if(slopeDownAngle != slopeDownAngleOld)
            {
                isOnSlope = true;
            }

            slopeDownAngleOld = slopeDownAngle;

            Debug.DrawRay(hit.point, slopeNormalPerp, Color.red);
            Debug.DrawRay(hit.point, hit.normal, Color.green);
        }

        //ma zmieniac material zeby postac nie zjezdzala z gorki ale chyba n dziala
        if (isOnSlope && speedX == 0.0f)
        {
            rbPlayer.sharedMaterial = fullFriction;
        }
        else
        {
            rbPlayer.sharedMaterial = noFriction;
        }
    }

    //sprawia ze postac chodzi gora-dol
    private void MovementUp()
    {
        speedY = Input.GetAxisRaw("Horizontal") * movSpeed;
        rbPlayer.linearVelocity = new Vector2(0, speedY);
    }
}
