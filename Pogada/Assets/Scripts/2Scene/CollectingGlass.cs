using System.Collections;
using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;
    private static int collectedGlass;

    private void OnMouseDown()
    {
        StartCoroutine(wait());
        //gameObject.SetActive(false);
        //stateManager.GlassCollected++;

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

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.6f);
        gameObject.SetActive(false);
        stateManager.GlassCollected++;
    }

}
