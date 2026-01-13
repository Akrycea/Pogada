using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    public string ObjectName;
    public string WinObject;

    private bool isOnObject = true;

    public Vector3 currentPosition;

    public BirdsWin birdsWin;

    void Start()
    {
        currentPosition = gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit collision");
        //Debug.Log(collision.gameObject.name);
        //Debug.Log(collision.gameObject.transform.position);


        if (collision.CompareTag("BirdFree"))
        {
            isOnObject = true;
            currentPosition = collision.gameObject.transform.position;
            collision.gameObject.tag = "BirdTaken";
        }
        else if (collision.CompareTag("BirdTaken"))
        {

        }

        if(collision.gameObject.name == WinObject)
        {
            birdsWin.birdsWin += 1;
        }

        Debug.Log(birdsWin.birdsWin);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (isOnObject == true)
        {
            collision.gameObject.tag = "BirdFree";
            isOnObject = false;
        }

        if (collision.gameObject.name == WinObject)
        {
            birdsWin.birdsWin -= 1;
            
        }

        Debug.Log(birdsWin.birdsWin);
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }
    }

}