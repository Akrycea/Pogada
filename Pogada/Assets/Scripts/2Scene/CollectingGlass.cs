using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;
    [SerializeField] static int collectedGlass;

    private void OnMouseDown()
    {
        if (collectedGlass < 5)
        {
            collectedGlass++;
        }
        else
        {
            stateManager.GlassCollected = true;
        }
            gameObject.SetActive(false);
    }

}
