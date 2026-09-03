using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;
    private static int collectedGlass;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        stateManager.GlassCollected++;

        //if (collectedGlass < 4)
        //{
        //    collectedGlass++;
        //}
        //else
        //{
        //    stateManager.GlassCollected = true;
        //    GameObject.Find("Player").GetComponent<HintsPlaying>().changeHint("P7_DrzwiFiolet_2");
        //}
        //    
    }

}
