using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        stateManager.GlassCollected = true;
    }

}
