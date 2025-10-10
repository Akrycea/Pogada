using UnityEngine;

public class DiognalTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (!playerMovement.movingIncline)
        {

            playerMovement.movingIncline = true;

        }
        else
        {
            playerMovement.movingIncline = false;
        }

    }


}
