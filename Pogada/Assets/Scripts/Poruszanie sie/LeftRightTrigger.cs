using UnityEngine;

public class LeftRightTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (playerMovement.movingUp)
        {

            playerMovement.movingUp = false;
        }

    }
}
