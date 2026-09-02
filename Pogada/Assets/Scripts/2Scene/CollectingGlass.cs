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
            GameObject.Find("Player").GetComponent<HintsPlaying>().changeHint("P7_DrzwiFiolet_2");
        }
            gameObject.SetActive(false);
    }

}
