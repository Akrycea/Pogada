using UnityEngine;
using Yarn.Unity;

public class KidRunAway : MonoBehaviour
{
    private Transform kidTransform;

    [SerializeField] private Vector3 kidFuturePosition;

    [YarnCommand("RunAway")]
    public void kidRunAway()
    {
        //add place to move to here
        //gameobjet.transform = jakis vector kurde bele

        //to jest rozwiazanie TYLKO NA DEMO
        Debug.Log("moving child");
        kidTransform = gameObject.GetComponent<Transform>();
        kidTransform.Translate(kidFuturePosition);
    }
}
