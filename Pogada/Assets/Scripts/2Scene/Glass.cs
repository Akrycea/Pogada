using UnityEngine;

public class Glass : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 currentPosition;
    public Vector3 picturePosition;

    public string ObjectName;
    public string WinObject;

    private bool isOnObject = false;

    public GameObject picture;

    public GlassMinigameWin glassMinigameWin;

    [SerializeField] private GameObject currentObject;

    

    void Start()
    {
        startPosition = gameObject.transform.position;
        currentPosition = startPosition;

        picturePosition = picture.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Free"))
        {
            //isOnObject = true;
            currentPosition = collision.gameObject.transform.position;
            collision.gameObject.tag = "Taken";

            if (currentObject != null)
            {
                currentObject.gameObject.tag = "Free";
            }
            currentObject = collision.gameObject;


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
        //if (isOnObject == true)
        //{
        //    collision.gameObject.tag = "Free";
        //    isOnObject = false;
        //    currentPosition = startPosition;
        //    picture.SetActive(false);
        //}

        currentPosition = startPosition;
        picture.SetActive(false);
        currentObject.gameObject.tag = "Free";

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

            if(currentPosition == startPosition)
            {
                currentObject = null;

                if (currentObject != null)
                {
                    currentObject.gameObject.tag = "Free";
                }
            }

            //if(isOnObject == true)
            //{
            //    picture.SetActive(true);
            //    picture.transform.position = currentPosition;
            //    picture.transform.position += Vector3.right * 20f;
            //}
        }
        //if (isOnObject== false)
        //{
        //    picture.SetActive(false);
        //}
    }
}
