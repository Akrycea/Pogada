using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;

    void Start()
    {
       stateManager = GameObject.Find("PuzzleManager").GetComponent<StateManager>();

    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        stateManager.GlassCollected = true;
    }

}
