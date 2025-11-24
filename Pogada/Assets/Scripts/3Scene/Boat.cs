using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour
{
    public BoatMovement boatMovement;
    public TurtleMovement turtleMovement;

    private bool isRunning = false;

    //gracz
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;


    void Start()
    {
        //odniesienie do gracza
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnMouseDown()
    {
        boatMovement.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "zolw" && isRunning == false)
        {
            StartCoroutine(WaitTurtle());
        }

        IEnumerator WaitTurtle()
        {
            isRunning = true;
            yield return new WaitForSeconds(0.5f);
            boatMovement.enabled = false;
            yield return new WaitForSeconds(2f);
            boatMovement.enabled = true;
            turtleMovement.enabled = true;
        }
    }
}


