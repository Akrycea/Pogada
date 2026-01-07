using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRightMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerMovement pMovement;
    //poruszanie sie na prawo przez przycisk
    public void OnPointerDown(PointerEventData eventData)
    {
        pMovement.RBPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pMovement.RBPressed = false;
    }
}
