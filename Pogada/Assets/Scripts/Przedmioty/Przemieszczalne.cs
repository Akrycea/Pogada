using UnityEngine;

public class Przemieszczalne : MonoBehaviour
{
    private Camera mainCamera;

    private bool holdingCount = false;

    private int holdTimer = 0;

    public bool holdingItem = false;
    void Start()
    {
        mainCamera = Camera.main;
    }

    
    void Update()
    {
        //jeœli obiekt jest klikniêty to ci¹gnie go za myszk¹
        if (holdingItem)
        {
            Vector2 mousepos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousepos;
        }

        if (holdingCount)
        {
            holdTimer++;
        }
        else
        {
            holdTimer = 0;
        }
    }

    //sprawdza czy klikniêty i wy³¹cza fizyke jeœli tak
    private void OnMouseDown()
    {
        holdingCount = true;

        holdingItem = true;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;


    }

    private void OnMouseUp()
    {
        holdingCount = false;

        holdingItem = false;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }
}
