using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class KidRunAway : MonoBehaviour
{
    private Transform kidTransform;
    [SerializeField] private Transform kidFuturePosition;
    private SpriteRenderer kidRenderer;

    private void Start()
    {
        kidRenderer = GetComponent<SpriteRenderer>();
        kidRenderer.enabled = true;
    }

    [YarnCommand("RunAway")]
    public void kidRunAway()
    {
        Debug.Log("moving child");
        StartCoroutine(RunAway());
    }

    IEnumerator RunAway()
    {
        kidRenderer.enabled = false;
        yield return new WaitForSeconds(2);
        kidTransform = gameObject.GetComponent<Transform>();
        kidTransform.transform.position = kidFuturePosition.position;
        kidRenderer.enabled = true;
    }
}
