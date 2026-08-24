using UnityEngine;

public class CloudStairsMinigame : MonoBehaviour
{
    public int doneSteps = 0;
    [SerializeField] private Collider2D stepsCollider;
    [SerializeField] private Collider2D blockerCloudsCollider;
    
    void Update()
    {
        if (doneSteps == 5)
        {
            //stepsCollider = GameObject.Find("Teren_Ch-B").GetComponent<Collider2D>();
            stepsCollider.isTrigger = false;
            blockerCloudsCollider.isTrigger = true;
        }
    }
}
