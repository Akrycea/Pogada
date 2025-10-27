using UnityEngine;

public class PrzenoszeniePrzedmiotow : MonoBehaviour
{
    // po prostu przenosi przedmioty jak je zlapiesz

    private Vector3 screenPoint;
    private Vector3 offset;

    //check if u want the object to change its rigidbody type from static to dynamic
    public bool ChangeRigidBodyType;

    public bool ZezwolPrzenoszenie;

    void OnMouseDown()
    {
        if (ZezwolPrzenoszenie == true)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

            if (ChangeRigidBodyType == true)
            {
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }

    void OnMouseDrag()
    {
        if (ZezwolPrzenoszenie == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

}

