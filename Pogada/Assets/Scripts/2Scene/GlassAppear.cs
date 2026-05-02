using UnityEngine;

public class GlassAppear : MonoBehaviour
{
    public StateManager stateManager;
    public GameObject glass;
    private bool hasAppeared = false;

    void Update()
    {
        if (stateManager.GlassCollected && hasAppeared == false)
        {
            glass.SetActive(true);
            hasAppeared = true;
        }
    }
}
