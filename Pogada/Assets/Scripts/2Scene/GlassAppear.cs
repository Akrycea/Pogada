using UnityEngine;

public class GlassAppear : MonoBehaviour
{
    public StateManager stateManager;
    public GameObject glass;
 

    private void OnMouseDown()
    {
        glass.SetActive(true);
    }
}
