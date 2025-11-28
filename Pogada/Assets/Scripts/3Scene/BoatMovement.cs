using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class BoatMovement : MonoBehaviour
{
    public Transform[] obstacles;

    public Vector3 startPosition;
    public Vector3 targetPosition;
    public float speed;

    public int arrayNumber = 0;

    public TurtleMovement turtleMovement;

    public ZielonyDebataPlayer zielonyDebataPlayer;


    void Start()
    {
        startPosition = gameObject.transform.position;
        targetPosition = obstacles[0].transform.position;
    }

  
    void Update()
    {
        Vector3 movingDirection = targetPosition - transform.position;
        movingDirection = movingDirection.normalized * Time.deltaTime * speed;
        float maxDystans = Vector3.Distance(transform.position, targetPosition);
        transform.position = transform.position + Vector3.ClampMagnitude(movingDirection, maxDystans);

        if(gameObject.transform.position == targetPosition)
        {
            arrayNumber ++;
            targetPosition = obstacles[arrayNumber].transform.position;
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "zolw" && collision.gameObject.name != "koniec")
        {
            if (collision.CompareTag("ZGpassable"))
            {
                
            }

            if (collision.CompareTag("ZGnotpassable"))
            {
                transform.position = startPosition;
                targetPosition = obstacles[0].transform.position;
                arrayNumber = 0;
                enabled = false;
            }
        }
        else if (collision.gameObject.name == "zolw")
        {
            
        }
        else if (collision.gameObject.name == "koniec")
        {
            zielonyDebataPlayer.wygranaMinigierka = true;
            gameObject.SetActive(false);
            Debug.Log("koniec, done");
            enabled = false;
        }
    }
}
