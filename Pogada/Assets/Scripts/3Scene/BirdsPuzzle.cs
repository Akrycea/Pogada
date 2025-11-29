using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    public string ObjectName;
    private bool isOnObject;
    private bool available;

    public Vector3 currentPosition;


    void OnTriggerEnter2D(Collider2D collision)
    {
        // debug i used for tests
        Debug.Log("Hit collision");
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.transform.position);
 

        isOnObject = true;
        currentPosition = collision.gameObject.transform.position;
        

        if(collision.CompareTag("BirdFree"))
        {
            available = true;
            collision.gameObject.tag = "BirdTaken";
        }
        else if (collision.CompareTag("BirdTaken"))
        {
            available = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {   
        isOnObject = false;
        

        if (available == true)
        {
            collision.gameObject.tag = "BirdFree";
        }
    }

    void Update()
    {
        if (isOnObject == true && available == true && Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }
    }
}

