using UnityEngine;

public class GlassAppear : MonoBehaviour
{
    public StateManager stateManager;
    public GameObject glass;
 

    private void OnMouseDown()
    {
        if(stateManager.GlassCollected == true)
        {
            glass.SetActive(true);
        }
            
    }
}
