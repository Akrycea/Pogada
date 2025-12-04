using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    public string ObjectName;
    private bool isOnObject;

    public Vector3 currentPosition;


    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit collision");
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.transform.position);
 
        isOnObject = true;
        currentPosition = collision.gameObject.transform.position;

       
    }

    void OnTriggerExit2D(Collider2D collision)
    {   
        isOnObject = false;
    }

    void Update()
    {
        if (isOnObject == true && Input.GetMouseButton(0) == false)
        {
            gameObject.transform.position = currentPosition;
        }
    }

}

