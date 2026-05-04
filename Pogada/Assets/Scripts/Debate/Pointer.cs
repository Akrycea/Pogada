using UnityEngine;

public class Pointer : MonoBehaviour
{

    public RectTransform safeZone; // Reference to the safe zone RectTransform
    private RectTransform pointerTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointerTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 100 * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            CheckSuccess();
        }
    }




    void CheckSuccess()
    {
        // Check if the pointer is within the safe zone
        if (RectTransformUtility.RectangleContainsScreenPoint(safeZone, pointerTransform.position, null))
        {
            Debug.Log("Success!");
        }
        else
        {
            Debug.Log("Fail!");
        }
    }
}
