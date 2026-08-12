using System.Collections;
using UnityEngine;

public class TESTturningoffplayercollider : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;

    private void Start()
    {
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {
        yield return new WaitForSeconds(5f);
        playerRigidbody.bodyType = RigidbodyType2D.Dynamic;
    }
}
