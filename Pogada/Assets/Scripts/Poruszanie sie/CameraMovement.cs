using System.Collections;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public CameraChange cameraChange;

    public bool cameraFreeMovement = false;


    void Start()
    {

    }


    void Update()
    {
        //sprawdza czy jest wlaczona duza kamera i od tego zaleznie ustawia kamere
        if (!cameraChange.cameraUp)
        {
            
           transform.position = new Vector3(target.position.x + 6, transform.position.y, -1.6f);
            
        }
        else
        {
            transform.position = new Vector3(target.position.x + 30, transform.position.y, -1.6f);
        }



    }

}
