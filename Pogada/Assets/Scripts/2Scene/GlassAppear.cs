using UnityEngine;

public class GlassAppear : MonoBehaviour
{
    public StateManager stateManager;
    public GameObject glass;
    [SerializeField] private GameObject glassUI;

    private void OnMouseDown()
    {
        if(stateManager.GlassCollected == 4)
        {
            glass.SetActive(true);
            glassUI.SetActive(false);
        }   
    }
}
