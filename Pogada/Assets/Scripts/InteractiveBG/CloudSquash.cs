using UnityEngine;
using System.Collections;

public class CloudSquash : MonoBehaviour
{
    public float duration = 0.5f;
    public float stretchAmount = 0.15f;

    private Vector3 originalScale;
    private bool isAnimating = false;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        if (!isAnimating)
            StartCoroutine(SquashAnimation());
    }

    IEnumerator SquashAnimation()
    {
        isAnimating = true;

        float timer = 0;

        while (timer < duration)
        {
            timer += Time.deltaTime;

            float t = timer / duration;

            // p³ynna animacja
            float value = Mathf.Sin(t * Mathf.PI);

            float scaleX = 1 + value * stretchAmount;
            float scaleY = 1 - value * stretchAmount;

            transform.localScale = new Vector3(
                originalScale.x * scaleX,
                originalScale.y * scaleY,
                originalScale.z
            );

            yield return null;
        }

        transform.localScale = originalScale;
        isAnimating = false;
    }
}