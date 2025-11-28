using UnityEngine;
using System.Collections;

public class TimedObstacle : MonoBehaviour
{
    public Obstacles obstacles;


    void Start()
    {
        obstacles.state = false;
    }

    private void OnMouseDown()
    {
        StartCoroutine(WaitObst());
    }
    

    IEnumerator WaitObst()
    {
        obstacles.state = true;
        yield return new WaitForSeconds(5f);
        obstacles.state = false;  
    }

}
