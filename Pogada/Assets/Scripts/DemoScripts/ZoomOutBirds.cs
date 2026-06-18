using UnityEngine;

public class ZoomOutBirds : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;

    [SerializeField]
    private GameObject birdCameraButton;

    [SerializeField]
    private PlayerMovement playerMovement;
    public void ZoomOut()
    {
        camera.SetActive(false);
        birdCameraButton.SetActive(true);
        playerMovement.canPlayerMove = true;
        gameObject.SetActive(false);
    }
}
