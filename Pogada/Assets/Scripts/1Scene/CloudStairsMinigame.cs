using UnityEngine;

public class CloudStairsMinigame : MonoBehaviour
{
    public int doneSteps = 0;
    private Collider2D stepsCollider;
    
    void Update()
    {
        if (doneSteps == 5)
        {
            Debug.Log(doneSteps);
            stepsCollider = GameObject.Find("Teren_Ch-B").GetComponent<Collider2D>();
            stepsCollider.isTrigger = false;
        }
    }
}
