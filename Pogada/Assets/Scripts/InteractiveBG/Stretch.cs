using UnityEngine;
using System.Collections;

public class Stretch : MonoBehaviour
{
    [Header("Animation Settings")]
    [SerializeField] private float stretchAmount = 1.15f;
    [SerializeField] private float stretchDuration = 0.15f;
    [SerializeField] private float returnDuration = 0.35f;

    private Vector3 originalScale;
    private Coroutine animationCoroutine;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        // Jeœli animacja ju¿ trwa, zaczynamy j¹ od pocz¹tku
        if (animationCoroutine != null)
        {
            StopCoroutine(animationCoroutine);
        }

        animationCoroutine = StartCoroutine(StretchAnimation());
    }

    private IEnumerator StretchAnimation()
    {
        // Rozci¹gniêcie w pionie
        Vector3 stretchedScale = new Vector3(
            originalScale.x,
            originalScale.y * stretchAmount,
            originalScale.z
        );

        // Rozci¹ganie
        float time = 0f;

        while (time < stretchDuration)
        {
            time += Time.deltaTime;

            float t = time / stretchDuration;

            // SmoothStep = p³ynniejsza animacja
            t = t * t * (3f - 2f * t);

            transform.localScale = Vector3.Lerp(
                originalScale,
                stretchedScale,
                t
            );

            yield return null;
        }

        transform.localScale = stretchedScale;

        // Powrót do normalnego rozmiaru
        time = 0f;

        while (time < returnDuration)
        {
            time += Time.deltaTime;

            float t = time / returnDuration;
            t = t * t * (3f - 2f * t);

            transform.localScale = Vector3.Lerp(
                stretchedScale,
                originalScale,
                t
            );

            yield return null;
        }

        transform.localScale = originalScale;
        animationCoroutine = null;
    }
}