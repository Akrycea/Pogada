using UnityEngine;

public class CameraAnim1 : MonoBehaviour
{
    Camera camera;
    public GameObject player;
    public Animator cameraAnimator;
    private bool cameraUp;
    void Start()
    {
        camera = Camera.main;
        cameraUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision happened");
        if (!cameraUp)
        {
            cameraAnimator.Play("CameraUpp");
            cameraUp = true;
        }
        else
        {
            cameraAnimator.Play("CameraDown");
            cameraUp = false;
        }
    }


}
