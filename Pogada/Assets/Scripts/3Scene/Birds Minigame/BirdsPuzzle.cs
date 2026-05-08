using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    public GameObject currentObject;
    public string WinObject;

    //private bool isOnObject = true;

    public Vector3 currentPosition;

    public BirdsWin birdsWin;

    public GameObject ChatBox;

    

    void Start()
    {
        currentPosition = gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Free"))
        {
            //isOnObject = true;
            currentPosition = collision.gameObject.transform.position;
            collision.gameObject.tag = "Taken";
            currentObject.gameObject.tag = "Free";
            currentObject = collision.gameObject;
        }

        if(collision.gameObject.name == WinObject)
        {
            birdsWin.GoodSpot();
        }  
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == WinObject)
        {
            birdsWin.BadSpot(); 
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }
    }


    //showing the chatbox when the player is hovering over the bird, and hiding it when they are not
    public void OnMouseOver()
    {
        ChatBox.SetActive(true);
    }

    public void OnMouseExit()
    {
        ChatBox.gameObject.SetActive(false);
    }

}