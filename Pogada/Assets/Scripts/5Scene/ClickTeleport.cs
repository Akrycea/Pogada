using UnityEngine;

public class ClickTeleport : MonoBehaviour
{
    [SerializeField] private EditCamera editCameraScript;
    [SerializeField] private Transform player;
    [SerializeField] private Transform teleport;

    private void OnMouseDown()
    {
        editCameraScript.ChangeCamera();
        player.position = teleport.position;
    }
}
