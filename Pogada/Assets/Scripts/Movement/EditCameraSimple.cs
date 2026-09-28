using UnityEngine;

public class EditCameraSimple : MonoBehaviour
{
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
        if (nextCamera.activeSelf == false)
        {
            nextCamera.SetActive(true);
        }
        else if (nextCamera.activeSelf == true)
        {
            nextCamera.SetActive(false);
        }
    }
}
