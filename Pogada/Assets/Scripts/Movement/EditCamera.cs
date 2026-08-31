using Unity.VisualScripting;
using UnityEngine;
using Unity.Cinemachine;

public class EditCamera : MonoBehaviour
{
    //main camera, these parameters will be changed
    //[SerializeField] private Camera cameraMain;

    //editable parameters; DO NOT LEAVE EMPTY!
    //[SerializeField] private float size;
    //public float horizontalTargetDistance;
    //public float verticalTargetDistance;

    //public CameraMovement camMovementScript;

    [SerializeField] private PlayerMovement pMovement;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("touhed camera");
            ChangeCamera();
        }
    }

    [SerializeField] private GameObject nextCamera;
    public void ChangeCamera()
    {
        if (nextCamera.activeSelf == false && !pMovement.flipped)
        {
            nextCamera.SetActive(true);
        }
        else if (nextCamera.activeSelf == true && pMovement.flipped) 
        {
            nextCamera.SetActive(false);
        }
    }
}
