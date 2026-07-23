using UnityEngine;
using System.Collections;

public class WindMove : MonoBehaviour
{
    public float distance = 0.15f;
    public float duration = 1.5f;

    private Vector3 startPos;
    private bool isMoving = false;

    private void Start()
    {
        startPos = transform.localPosition;
    }

    private void OnMouseDown()
    {
        if (!isMoving)
            StartCoroutine(Sway());
    }

    IEnumerator Sway()
    {
        isMoving = true;

        float timer = 0;

        while (timer < duration)
        {
            timer += Time.deltaTime;

            float x = Mathf.Sin(timer * Mathf.PI * 4) *
                      distance *
                      (1 - timer / duration);

            transform.localPosition = startPos + new Vector3(x, 0, 0);

            yield return null;
        }

        transform.localPosition = startPos;
        isMoving = false;
    }
}
