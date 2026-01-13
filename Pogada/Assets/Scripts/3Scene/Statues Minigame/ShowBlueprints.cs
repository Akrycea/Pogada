using UnityEngine;

public class ShowBlueprints : MonoBehaviour
{
    public GameObject blueprintsUI;

    public void OnMouseDown()
    {
        if (blueprintsUI.activeInHierarchy == true)
        {
            blueprintsUI.SetActive(false);
            gameObject.SetActive(true);
        }
    }
}
