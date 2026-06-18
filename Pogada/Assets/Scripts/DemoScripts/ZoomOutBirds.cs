using UnityEngine;

public class ZoomOutBirds : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;

    [SerializeField]
    private GameObject birdCameraButton;
    public void ZoomOut()
    {
        camera.SetActive(false);
        birdCameraButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
