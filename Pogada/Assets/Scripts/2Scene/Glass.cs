using UnityEngine;

public class Glass : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 currentPosition;

    public string ObjectName;
    public string WinObject;

    private bool isOnObject = false;

    public GameObject picture;

    public GlassMinigameWin glassMinigameWin;

    void Start()
    {
        startPosition = gameObject.transform.position;
        currentPosition = startPosition;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Free"))
        {
            isOnObject = true;
            currentPosition = collision.gameObject.transform.position;
            collision.gameObject.tag = "Taken";
        }

        if (collision.gameObject.name == WinObject)
        {
            glassMinigameWin.GoodSpot(); 
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {       
        if (isOnObject == true)
        {
            collision.gameObject.tag = "Free";
            isOnObject = false;
            currentPosition = startPosition;
        }

        if (collision.gameObject.name == WinObject)
        {
            glassMinigameWin.BadSpot();
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;

            if(isOnObject == true)
            {
                picture.SetActive(true);
            }
        }
        if (isOnObject== false)
        {
            picture.SetActive(false);
        }
    }
}
