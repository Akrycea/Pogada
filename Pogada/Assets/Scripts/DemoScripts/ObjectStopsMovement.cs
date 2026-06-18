using UnityEngine;

public class ObjectStopsMovement : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;
    void Update()
    {
        if(gameObject.activeSelf)
        {
            playerMovement.canPlayerMove = false;
        }

    }
}
