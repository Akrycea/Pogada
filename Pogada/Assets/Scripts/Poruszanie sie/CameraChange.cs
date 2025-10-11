using UnityEngine;

public class CameraChange : MonoBehaviour
{
    //kamera chodzaca za graczem
    public Camera camera1;

    //statyczna kamera na góry
    public Camera camera2;
    public bool cameraUp;
    void Start()
    {
        camera1 = Camera.main;
        camera1.enabled = true;


        camera2.enabled = false;
        cameraUp = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (!cameraUp)
        {
            cameraUp = true;
            camera2.enabled = true;
            
            camera1.enabled = false;
        }
        else
        {
            cameraUp = false;
            camera1.enabled = true;

            camera2.enabled = false;
        }
    }


}
