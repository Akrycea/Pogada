using System.Collections;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    //target to follow player left-right
    public Transform playerTarget;

    public CameraChange cameraChange;

    public bool cameraFreeMovement = false;

    private float OgHorizontalTargetDistance;
    private float OgVerticalTargetDistance;
    private float OgZetTargetDistance = -1.6f;

    private float YcameraHight;

    public EditCamera editCameraScript;


    void Start()
    {
        OgHorizontalTargetDistance = 6;
        OgVerticalTargetDistance = -37.87426f;
    }


    void Update()
    {
        transform.position = new Vector3(playerTarget.position.x + OgHorizontalTargetDistance,
            OgVerticalTargetDistance, OgZetTargetDistance);
    }

    public void ChangeCameraPosition()
    {
        OgHorizontalTargetDistance = editCameraScript.horizontalTargetDistance;
        OgVerticalTargetDistance = editCameraScript.verticalTargetDistance;
    }

}
