using Unity.Cinemachine;
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

    //public CameraMovement camMovementScript;
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.name == "Player")
    //    {
    //        //Debug.Log("touhed camera");
    //        //camMovementScript.editCameraScript = gameObject.GetComponent<EditCamera>();
    //        //ChangeCameraParameters();
    //    }
    //}

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            ChangeCamera();
        }
    }


    //private void ChangeCameraParameters()
    //{
    //    cameraMain.orthographicSize = size;
    //    camMovementScript.ChangeCameraPosition();
    //}

    [SerializeField] private GameObject nextCamera;
    private void ChangeCamera()
    {
        if (nextCamera.activeSelf == false)
        {
            nextCamera.SetActive(true);
        }
        else
        {
            nextCamera.SetActive(false);
        }
    }
}
