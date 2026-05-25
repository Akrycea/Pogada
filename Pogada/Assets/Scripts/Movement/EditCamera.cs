using Unity.VisualScripting;
using UnityEngine;

public class EditCamera : MonoBehaviour
{
    //main camera, these parameters will be changed
    [SerializeField] private Camera cameraMain;

    //editable parameters; DO NOT LEAVE EMPTY!
    [SerializeField] private float size;
    public float horizontalTargetDistance;
    public float verticalTargetDistance;

    public CameraMovement camMovementScript;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("touhed camera");
            camMovementScript.editCameraScript = gameObject.GetComponent<EditCamera>();
            ChangeCameraParameters();
        }
    }
        

    private void ChangeCameraParameters()
    {
        cameraMain.orthographicSize = size;
        camMovementScript.ChangeCameraPosition();
    }
}
