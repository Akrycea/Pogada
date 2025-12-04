using UnityEngine;

public class BirdsPuzzle : MonoBehaviour
{
    public string ObjectName;
    private bool isOnObject = true;

    public Vector3 currentPosition;


    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit collision");
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.transform.position);




        if (collision.CompareTag("BirdFree"))
        {
            isOnObject = true;
            currentPosition = collision.gameObject.transform.position;
            collision.gameObject.tag = "BirdTaken";
        }
        else if (collision.CompareTag("BirdTaken"))
        {

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (isOnObject == true)
        {
            collision.gameObject.tag = "BirdFree";
            isOnObject = false;
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