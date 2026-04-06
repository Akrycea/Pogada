using UnityEngine;

public class IngredientControl : MonoBehaviour
{
    private Vector3 originalPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }


    public void ReturnToPosition()
    {
        gameObject.SetActive(true);
        transform.position = originalPosition;
    }
}
