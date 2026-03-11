using Unity.VisualScripting;
using UnityEngine;

public class EditCamera : MonoBehaviour
{
    //main camera, these parameters will be changed
    [SerializeField] private Camera cameraMain;

    //editable parameters; DO NOT LEAVE EMPTY!
    [SerializeField] private float fov;
    public float horizontalTargetDistance;
    public float verticalTargetDistance;

    public CameraMovement camMovementScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camMovementScript.editCameraScript = gameObject.GetComponent<EditCamera>();
        ChangeCameraParameters();
    }
        

    private void ChangeCameraParameters()
    {
        cameraMain.fieldOfView = fov;
        camMovementScript.ChangeCameraPosition();
    }
}
