using System.Collections;
using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject currentObject;
    [SerializeField] private GameObject WinObject;

    [SerializeField] private Vector2 currentPosition;

    [SerializeField] private BirdsWin birdsWin;

    [SerializeField] private GameObject ChatBox;

    [SerializeField] static bool birdTalking = false;

    [SerializeField] private bool Win = false;
    [SerializeField] private bool WinAnimPlayed = false;


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

            if (collision.gameObject == WinObject)
            {
                birdsWin.GoodSpot();
                Win = true;
            }
        }

        
    }

       

    void OnTriggerExit2D(Collider2D collision)
    {
        if (Win == true && collision.gameObject == WinObject)
        {
            birdsWin.BadSpot(); 
            Win = false;
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }

        if(birdsWin.dialoguePlayed)
        {
            //this should stop player from moving birds if the minigame is won
            gameObject.GetComponent<Drag>().AllowDrag = false;
            gameObject.GetComponent<Outline>().interactable = false;
            gameObject.GetComponent<BirdsPuzzle>().enabled = false;
        }

        if (Win == true && WinAnimPlayed == false && Input.GetMouseButton(0) == false)
        {
            gameObject.GetComponent<InteractionAnimation>().shineAnim();
            WinAnimPlayed = true;
        }
    }

    private bool hasSaidVoiceline = false;
    private AudioSource audio;


    //showing the chatbox when the player is hovering over the bird, and hiding it when they are not
    public void OnMouseOver()
    {
        if (!birdsWin.dialoguePlayed)
        {
            ChatBox.SetActive(true);

            if (!hasSaidVoiceline && !birdTalking)
            {
                birdTalking = true;
                audio = gameObject.GetComponent<AudioSource>();
                audio.Play();
                StartCoroutine(waitToSayThing());
            }
        }
    }

    public void OnMouseExit()
    {
        ChatBox.gameObject.SetActive(false);
    }

    IEnumerator waitToSayThing()
    {
        yield return new WaitForSeconds(4);
        hasSaidVoiceline = true;

        //this bool should make it so only one bird can speak at a time
        birdTalking = false;
    }

}