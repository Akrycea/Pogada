using System.Collections;
using UnityEngine;


public class CameraFreeMovement : MonoBehaviour
{
    //skrypt na kamere ktora chodzi za graczem tez gora dol

    public Transform target;
    private Camera cameraSelf;

    public bool cameraFreeMovement = false;


    void Start()
    {
        cameraSelf = GetComponent<Camera>();
    }


    void Update()
    {
        if (cameraSelf.enabled)
        {
            transform.position = new Vector3(target.position.x + 1.5f, target.position.y, -1.6f);
        }


    }

}
