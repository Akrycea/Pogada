using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Turtle : MonoBehaviour
{
    public TurtleMovement turtleMovement;

    [SerializeField] private GameObject turtleSpot;

    void Update()
    {
        if(turtleMovement.cameBack)
        {
            turtleMovement.enabled = false;
            gameObject.tag = "ZGpassable";
            turtleSpot.tag = "ZGpassable";
        }
    }

    void OnMouseDown()
    {
        turtleMovement.cameBack = false;
        turtleMovement.enabled = true;

        gameObject.tag = "ZGnotpassable";
        turtleSpot.tag = "ZGnotpassable";
    }
}
