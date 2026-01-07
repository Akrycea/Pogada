using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLeftMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerMovement pMovement;
    //poruszanie sie na lewo przez przycisk
    public void OnPointerDown(PointerEventData eventData)
    {
        pMovement.LBPressed = true;
        Debug.Log("poressed left button");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pMovement.LBPressed = false;
    }
}
