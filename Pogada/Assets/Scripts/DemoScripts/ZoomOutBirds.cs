using UnityEngine;

public class ZoomOutBirds : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;

    [SerializeField]
    private GameObject birdCameraButton;

    [SerializeField]
    private PlayerMovement playerMovement;

    [SerializeField] private BirdsWin birdsWin;
    public void ZoomOut()
    {
        camera.SetActive(false);
        playerMovement.canPlayerMove = true;
        gameObject.SetActive(false);

        if (birdsWin.dialoguePlayed)
        {
            birdCameraButton.SetActive(false);
        }
        else
        {
            birdCameraButton.SetActive(true);
        }
    }
}
