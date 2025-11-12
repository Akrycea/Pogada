using UnityEngine;

public class Lodka : MonoBehaviour
{
    public LodkaPoruszanie lodkaPoruszanie;

    void OnMouseDown()
    {
        lodkaPoruszanie.enabled = true;
    }
}
