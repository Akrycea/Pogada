using UnityEngine;

public class TurnOffCollider : MonoBehaviour
{

    public void DisableAllExceptSpecificTag()
    {
        //Find every collider in the scene (including inactive ones)
        Collider[] allColliders = FindObjectsByType<Collider>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Collider col in allColliders)
        {
            //Check if the GameObject hosting the collider has the excluded tag
            if (col.CompareTag("Ground"))
            {
                continue; // Skip this collider and move to the next one
            }

            //Disable all other colliders
            col.enabled = false;
        }
    }

    public void EnableAllColliders()
    {
        //Find every collider in the scene (including inactive ones)
        Collider[] allColliders = FindObjectsByType<Collider>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        foreach (Collider col in allColliders)
        {
            // Enable all colliders
            col.enabled = true;
        }
    }
}
