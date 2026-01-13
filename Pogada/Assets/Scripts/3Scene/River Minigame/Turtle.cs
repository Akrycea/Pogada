using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Turtle : MonoBehaviour
{
    public TurtleMovement turtleMovement;

    void Update()
    {
        if(turtleMovement.cameBack)
        {
            turtleMovement.enabled = false;
        }
    }

    void OnMouseDown()
    {
        turtleMovement.cameBack = false;
        turtleMovement.enabled = true;
    }

    


}
