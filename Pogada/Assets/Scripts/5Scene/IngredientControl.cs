using UnityEngine;
using System.Collections;

public class IngredientControl : MonoBehaviour
{
    [SerializeField] private Vector3 originalPosition;
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
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void OnMouseDown()
    {
        StartCoroutine(ReturnAfterTime());
    }

    private IEnumerator ReturnAfterTime()
    {
        yield return new WaitForSeconds(5f);
        transform.position = originalPosition;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
