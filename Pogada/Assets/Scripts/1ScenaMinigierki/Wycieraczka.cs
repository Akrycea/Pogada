using UnityEngine;

public class Wycieraczka : MonoBehaviour
{
    public bool otwartaWycieraczka = false;

    public PrzenoszeniePrzedmiotow przenoszeniePrzedmiotow;

    public void OnMouseDown()
    {
        przenoszeniePrzedmiotow.ZezwolPrzenoszenie = true;
        otwartaWycieraczka = true;
    }
}
