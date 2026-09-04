using UnityEngine;
using System.Collections;

public class IngredientControl : MonoBehaviour
{
    private Vector3 originalPosition;
    public Drag drag;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }


    public void ReturnToPosition()
    {
        gameObject.SetActive(true);
        transform.position = originalPosition;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }

    public void OnMouseDown()
    {
        StartCoroutine(ReturnAfterTime());
    }

    private IEnumerator ReturnAfterTime()
    {
        yield return new WaitForSeconds(5f);
        transform.position = originalPosition;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }
}
