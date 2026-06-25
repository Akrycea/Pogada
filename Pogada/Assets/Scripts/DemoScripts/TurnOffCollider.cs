using UnityEngine;
using Yarn.Unity;

public class TurnOffCollider : MonoBehaviour
{
    [YarnCommand("DisableColliders")]
    public void DisableAllExceptSpecificTag()
    {
        //Find every collider in the scene (including inactive ones)
        Collider2D[] allColliders = FindObjectsByType<Collider2D>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Collider2D col in allColliders)
        {
            //Check if the GameObject hosting the collider has the excluded tag
            if (col.CompareTag("Ground"))
            {
                continue; // Skip this collider and move to the next one
            }

            if (col.CompareTag("puzzle"))
            {
                continue; // Skip this collider and move to the next one
            }

            //Disable all other colliders
            col.enabled = false;
        }
    }


    [YarnCommand("EnableColliders")]
    public void EnableAllColliders()
    {
        //Find every collider in the scene (including inactive ones)
        Collider2D[] allColliders = FindObjectsByType<Collider2D>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (Collider2D col in allColliders)
        {
            // Enable all colliders
            col.enabled = true;
        }
    }


}
