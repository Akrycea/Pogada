using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class StopCameraMovementUp : MonoBehaviour
{
    public Camera camera5;
    public Camera camera4;
    public CameraChange cameraChange;
    void Start()
    {
        camera5.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dotkniete");
        camera4.enabled = false;
        camera5.enabled = true;
        cameraChange.cameraUp = false;
        Destroy(gameObject);
    }
}
