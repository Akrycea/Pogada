using UnityEngine;

public class Wycieraczka : MonoBehaviour
{
    public bool otwartaWycieraczka = false;

    public Drag drag;

    public void OnMouseDown()
    {
        drag.ZezwolPrzenoszenie = true;
        otwartaWycieraczka = true;
    }
}
