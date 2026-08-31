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
        yield return new WaitForSeconds(1);
        kidTransform = gameObject.GetComponent<Transform>();
        kidTransform.transform.position = kidFuturePosition.position;
        kidRenderer.enabled = true;
    }

    [YarnCommand("ParentsRunAway")]
    public void ParentsRunAway()
    {
        Debug.Log("moving parent");
        StartCoroutine(Away());
    }

    private SpriteRenderer ksiezyc;
    private SpriteRenderer slonce;
    IEnumerator Away()
    {
        yield return new WaitForSeconds(0.1f);
        ksiezyc = GameObject.Find("Ksiê¿yc").GetComponent<SpriteRenderer>();
        ksiezyc.enabled = false;
        slonce = GameObject.Find("S³oñce").GetComponent<SpriteRenderer>();
        slonce.enabled = false;
        yield return new WaitForSeconds(2f);
        kidTransform = gameObject.GetComponent<Transform>();
        kidTransform.transform.position = kidFuturePosition.position;
        kidRenderer.enabled = true;
    }
}
