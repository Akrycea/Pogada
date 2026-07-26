using UnityEngine;
using System.Collections;

public class StarGlow : MonoBehaviour
{
    public Color glowColor = Color.white;
    public float glowTime = 0.5f;
    public float glowScale = 1.3f;

    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private Vector3 originalScale;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        originalColor = spriteRenderer.color;
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        StartCoroutine(Glow());
    }

    IEnumerator Glow()
    {
        float timer = 0;

        while (timer < glowTime)
        {
            timer += Time.deltaTime;

            float t = Mathf.Sin(timer / glowTime * Mathf.PI);

            spriteRenderer.color = Color.Lerp(
                originalColor,
                glowColor,
                t
            );

            transform.localScale = Vector3.Lerp(
                originalScale,
                originalScale * glowScale,
                t
            );

            yield return null;
        }

        spriteRenderer.color = originalColor;
        transform.localScale = originalScale;
    }
}