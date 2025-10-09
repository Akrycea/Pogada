using System.Collections;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using static Yarn.Compiler.BasicBlock;

public class UpDownTrigger : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (!playerMovement.movingUp)
        {

            playerMovement.movingUp = true;
        }

    }

}
