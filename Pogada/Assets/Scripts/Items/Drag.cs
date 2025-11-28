using UnityEngine;

public class Drag : MonoBehaviour
{
    // po prostu przenosi przedmioty jak je zlapiesz
    private Vector3 screenPoint;
    private Vector3 offset;

    //check if u want the object to change its rigidbody type from static to dynamic
    public bool ChangeRigidBodyType;
    //pozwol na przenoszenie, normalnie na true
    public bool AllowDrag = true;

    //odniesienie do gracza
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    private void Start()
    {
        //znowu, to wszystko do playera
        //playerObject = GameObject.Find("Player");
        //player = playerObject.GetComponent<Transform>();
        //Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }


    void OnMouseDown()
    {
        if (AllowDrag == true)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

            //zmien rigid body
            if (ChangeRigidBodyType == true)
            {
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }


    void OnMouseDrag()
    {
        if (AllowDrag == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

}

