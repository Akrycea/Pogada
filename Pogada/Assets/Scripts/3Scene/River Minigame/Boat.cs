using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour
{
    public BoatMovement boatMovement;
    public TurtleMovement turtleMovement;

    private bool isRunning = false;
    private bool hitTurtle = false;

    void OnMouseDown()
    {
        boatMovement.enabled = true;
      
        if (hitTurtle)
        {
            turtleMovement.enabled = true;
            //boatMovement.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "zolw" && hitTurtle == false)
        {
            hitTurtle = true;

            StartCoroutine(WaitTurtle());
        }

        IEnumerator WaitTurtle()
        {
            //isRunning = true;
            yield return new WaitForSeconds(0.5f);
            boatMovement.enabled = false;
            
            //yield return new WaitForSeconds(2f);
            //boatMovement.enabled = true;
            //turtleMovement.enabled = true;
        }
    }
}


