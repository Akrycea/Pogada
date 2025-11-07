using UnityEngine;

public class Lodka : MonoBehaviour
{
    public LodkaPoruszanie lodkaPoruszanie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        lodkaPoruszanie.enabled = true;
    }
}
