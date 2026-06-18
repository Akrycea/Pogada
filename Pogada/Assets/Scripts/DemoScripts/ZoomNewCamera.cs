using UnityEngine;

public class ZoomNewCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;

    [SerializeField]
    private GameObject cameraBounds;

    [SerializeField]
    private bool needToOffCollider;

    [SerializeField]
    private GameObject zoomOutButton;

    private void OnMouseDown()
    {
        camera.SetActive(true);
        gameObject.SetActive(false);
        if (needToOffCollider)
        {
            cameraBounds.SetActive(false);
        }
        zoomOutButton.SetActive(true);
    }
}
