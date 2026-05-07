using UnityEngine;

public class Doormat : MonoBehaviour
{
    public bool openDoormat = false;

    public Drag drag;
      
    private Collider2D doormatCollider;

    public void OnMouseDown()
    {
        drag.AllowDrag = true;
        openDoormat = true;

        //¿eby nie da³o sie kliknac doormat po
        doormatCollider = GetComponent<Collider2D>();
        doormatCollider.enabled = false;
    }
}
