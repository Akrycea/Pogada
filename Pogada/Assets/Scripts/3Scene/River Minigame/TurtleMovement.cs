using UnityEngine;
using System.Collections;

public class TurtleMovement : MonoBehaviour
{
    public Turtle turtle;

    public Transform turtleTarget;

    public Vector3 startPosition;
    public Vector3 targetPosition;
    public float speed;

    public bool LeftRight = true;

    public bool cameBack = false;


    void Start()
    {
        startPosition = transform.position;
        targetPosition = turtleTarget.transform.position;
    }


    void Update()
    {
        Vector3 movingDirection = targetPosition - transform.position;
        movingDirection = movingDirection.normalized * Time.deltaTime * speed;
        float maxDystans = Vector3.Distance(transform.position, targetPosition);
        transform.position = transform.position + Vector3.ClampMagnitude(movingDirection, maxDystans);

        if(targetPosition == transform.position)
        {
            Debug.Log("dotknieto");

            if (LeftRight == true)
            {
                StartCoroutine(WaitLeft());
            }

            if (LeftRight == false)
            {
                StartCoroutine(WaitRight());
            }

            if(LeftRight == false && transform.position == startPosition)
            {
                cameBack = true;
                gameObject.tag = "ZGpassable";
            }
        }

        IEnumerator WaitLeft()
        {
            yield return new WaitForSeconds(2f);
            targetPosition = startPosition;
            LeftRight = false;
        }

        IEnumerator WaitRight()
        {
            yield return new WaitForSeconds(2f);
            targetPosition = turtleTarget.transform.position;
            LeftRight = true;
        }
    }



}
