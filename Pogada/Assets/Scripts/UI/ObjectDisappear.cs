using System.Collections;
using UnityEngine;

public class ObjectDisappear : MonoBehaviour
{
    [SerializeField] private float waitTime;
    void Start()
    {
        StartCoroutine(waitToDisappear());
    }

    IEnumerator waitToDisappear()
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.SetActive(false);
    }
}
