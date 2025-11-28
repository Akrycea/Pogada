using UnityEngine;

public class Doormat : MonoBehaviour
{
    public bool openDoormat = false;

    public Drag drag;

    public void OnMouseDown()
    {
        drag.AllowDrag = true;
        openDoormat = true;
    }
}
