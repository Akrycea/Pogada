using UnityEngine;
using System.Collections;

public class GemMovement : MonoBehaviour
{
    public float maxAngle = 8f;
    public float speed = 5f;
    public float duration = 1.5f;

    bool isAnimating = false;

    private void OnMouseDown()
    {
        if (!isAnimating)
            StartCoroutine(WindAnimation());
    }

    IEnumerator WindAnimation()
    {
        isAnimating = true;

        Quaternion startRotation = transform.rotation;

        float time = 0;

        while (time < duration)
        {
            time += Time.deltaTime;

            float angle = Mathf.Sin(time * speed * Mathf.PI) *
                          maxAngle *
                          (1 - time / duration);

            transform.rotation = startRotation * Quaternion.Euler(0, 0, angle);

            yield return null;
        }

        transform.rotation = startRotation;
        isAnimating = false;
    }
}