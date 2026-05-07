using UnityEngine;
using Yarn.Unity;

public class Pointer : MonoBehaviour
{

    public RectTransform safeZone; // Reference to the safe zone RectTransform

    public Transform pointA; // Reference to the starting point
    public Transform pointB; // Reference to the ending point
    public float moveSpeed = 100f; // Speed at which the pointer moves

    private float direction = 1f; // 1 for moving towards B, -1 for moving towards A
    private RectTransform pointerTransform;
    private Vector3 targetPosition;

    public Jab jab;

    public string good;
    public string bad;

    public DialogueRunner dialogueRunner;

    public GameObject jabOBJ;

    void Start()
    {
        pointerTransform = GetComponent<RectTransform>();
        targetPosition = pointB.position;
    }

    // Update is called once per frame
    void Update()
    {
        pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Change direction if the pointer reaches one of the points
        if (Vector3.Distance(pointerTransform.position, pointA.position) < 0.1f)
        {
            targetPosition = pointB.position;
            direction = 1f;
        }
        else if (Vector3.Distance(pointerTransform.position, pointB.position) < 0.1f)
        {
            targetPosition = pointA.position;
            direction = -1f;
        }

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
            dialogueRunner.StartDialogue(good);
            jabOBJ.SetActive(false);
        }
        else
        {
            Debug.Log("Fail!");
            dialogueRunner.StartDialogue(bad);
            jabOBJ.SetActive(false);
        }
    }
}
