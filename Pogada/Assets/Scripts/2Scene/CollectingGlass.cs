using System.Collections;
using UnityEngine;

public class CollectingGlass : MonoBehaviour
{
    public StateManager stateManager;
    private static int collectedGlass;

    [SerializeField] private GameObject glassUI;

    [SerializeField] private GameObject Spots;

    private void OnMouseDown()
    {
        StartCoroutine(wait());   
        
        if(stateManager.GlassCollected == 4)
        {
            Spots.SetActive(true);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
        stateManager.GlassCollected++;
        glassUI.SetActive(true);
    }

}
