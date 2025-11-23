using UnityEngine;

public class ChmuryMinigierka : MonoBehaviour
{
    public int doneSteps = 0;
    private Collider2D stepsCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
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
