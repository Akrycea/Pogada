using UnityEngine;

public class Glass : MonoBehaviour
{
    private Vector2 startPosition;
    [SerializeField]
    private Vector2 currentPosition;
    private Vector2 picturePosition;

    [SerializeField] private GameObject currentObject;
    [SerializeField] private GameObject picture;


    [SerializeField] private string WinObject;


    [SerializeField] GlassMinigameWin glassMinigameWin;





    void Start()
    {
        startPosition = gameObject.transform.position;
        currentPosition = startPosition;

        picturePosition = picture.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("EnterCollider");

        if (collision.CompareTag("Free"))
        {
            collision.gameObject.tag = "Taken";

            currentObject = collision.gameObject;
            currentPosition = collision.gameObject.transform.position;


            picture.SetActive(true);
            picture.transform.position = currentPosition;
            picture.transform.position += Vector3.right * 10f;


            if (collision.gameObject.name == WinObject)
            {
                glassMinigameWin.GoodSpot();
                picture.SetActive(true);
                picture.transform.position = picturePosition;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("ExitCollider");

        if (collision.gameObject == currentObject)
        {
            collision.gameObject.tag = "Free";
            currentObject = null;
            currentPosition = startPosition;
            picture.SetActive(false);

            if (collision.gameObject.name == WinObject)
            {
                glassMinigameWin.BadSpot();
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }
    }
}
