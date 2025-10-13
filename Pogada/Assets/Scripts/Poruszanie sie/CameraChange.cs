using System.Collections;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    //kamera chodzaca za graczem1
    public Camera camera1;

    //kamera na góry
    public Camera camera2;

    //kamera chodzaca za graczem2
    public Camera camera3;

    public bool cameraUp;
    public bool cameraDown;
    void Start()
    {
        //camera1 = Camera.main;
        camera1.enabled = true;


        camera2.enabled = false;
        camera3.enabled = false;

        cameraUp = false;
        cameraDown = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (!cameraUp)
        {
            camera2.enabled = true;

            camera1.enabled = false;
            cameraUp = true;
        }   
        else
        {
            cameraUp = false;
            camera3.enabled = true;

            camera2.enabled = false;
        }
    }




}
