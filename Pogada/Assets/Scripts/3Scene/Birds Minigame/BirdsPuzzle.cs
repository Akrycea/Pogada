using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject currentObject;
    [SerializeField] private GameObject WinObject;

    [SerializeField] private Vector2 currentPosition;

    [SerializeField] private BirdsWin birdsWin;

    [SerializeField] private GameObject ChatBox;

    

    void Start()
    {
        currentPosition = gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Free"))
        {
            currentPosition = collision.gameObject.transform.position;

            collision.gameObject.tag = "Taken";

            currentObject.gameObject.tag = "Free";
            currentObject = collision.gameObject;
        }

        if(collision.gameObject == WinObject)
        {
            birdsWin.GoodSpot();
        }  
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == WinObject)
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

    private bool hasSaidVoiceline = false;
    private AudioSource audio;


    //showing the chatbox when the player is hovering over the bird, and hiding it when they are not
    public void OnMouseOver()
    {
        ChatBox.SetActive(true);

        if (!hasSaidVoiceline)
        {
            audio = gameObject.GetComponent<AudioSource>();
            audio.Play();
            hasSaidVoiceline = true;
        }
    }

    public void OnMouseExit()
    {
        ChatBox.gameObject.SetActive(false);
    }

}