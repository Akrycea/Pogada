using UnityEngine;
using System.Collections;

public class CartoonShake : MonoBehaviour
{
    [Header("Shake")]
    [SerializeField] private float shakeWidth = 0.04f;
    [SerializeField] private float shakeFrequency = 18f;
    [SerializeField] private float shakeDuration = 0.5f;

    [Header("Rotation")]
    [SerializeField] private bool changeAngle = true;
    [SerializeField] private float angleVariation = 3f;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private Coroutine shakeCoroutine;

    private void Start()
    {
        originalPosition = transform.localPosition;
        originalRotation = transform.localRotation;
    }

    private void OnMouseDown()
    {
        if (shakeCoroutine != null)
        {
            StopCoroutine(shakeCoroutine);

            // Wracamy do pozycji bazowej
            transform.localPosition = originalPosition;
            transform.localRotation = originalRotation;
        }

        shakeCoroutine = StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        float time = 0f;

        // Losowy kierunek dla ka¿dego shake'a
        float randomX = Random.Range(0f, 100f);
        float randomY = Random.Range(0f, 100f);

        float randomAngle = Random.Range(0f, 100f);

        while (time < shakeDuration)
        {
            time += Time.deltaTime;

            // --------------------------------
            // WYGASZANIE SHAKE'A
            // --------------------------------

            float progress = time / shakeDuration;

            // Mocno na pocz¹tku, delikatnie na koñcu
            float fade = 1f - progress;

            // --------------------------------
            // RUCH X / Y
            // --------------------------------

            float x = Mathf.PerlinNoise(
                randomX,
                time * shakeFrequency
            ) * 2f - 1f;

            float y = Mathf.PerlinNoise(
                randomY,
                time * shakeFrequency
            ) * 2f - 1f;

            Vector3 offset = new Vector3(
                x * shakeWidth * fade,
                y * shakeWidth * fade,
                0f
            );

            transform.localPosition = originalPosition + offset;

            // --------------------------------
            // DELIKATNA ZMIANA K¥TA
            // --------------------------------

            if (changeAngle)
            {
                float angle = Mathf.PerlinNoise(
                    randomAngle,
                    time * shakeFrequency * 0.5f
                ) * 2f - 1f;

                angle *= angleVariation * fade;

                transform.localRotation =
                    originalRotation *
                    Quaternion.Euler(0f, 0f, angle);
            }

            yield return null;
        }

        // Wracamy dok³adnie na miejsce
        transform.localPosition = originalPosition;
        transform.localRotation = originalRotation;

        shakeCoroutine = null;
    }
}