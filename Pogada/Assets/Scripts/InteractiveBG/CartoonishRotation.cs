using UnityEngine;
using System.Collections;

public class CartoonishRotation : MonoBehaviour
{
    [Header("Cartoon Rotation")]
    [SerializeField] private float rotationAmount = 12f;
    [SerializeField] private float overshootAmount = 5f;
    [SerializeField] private float duration = 0.45f;

    private Quaternion originalRotation;
    private Coroutine animationCoroutine;

    private void Start()
    {
        originalRotation = transform.localRotation;
    }

    private void OnMouseDown()
    {
        if (animationCoroutine != null)
        {
            StopCoroutine(animationCoroutine);
        }

        animationCoroutine = StartCoroutine(CartoonRotation());
    }

    private IEnumerator CartoonRotation()
    {
        float time = 0f;

        // Losujemy kierunek obrotu
        float direction = Random.value > 0.5f ? 1f : -1f;

        Quaternion start = originalRotation;

        // G³ówny obrót
        Quaternion rotate = originalRotation *
            Quaternion.Euler(0f, 0f, rotationAmount * direction);

        // Lekkie przekroczenie w drug¹ stronê
        Quaternion overshoot = originalRotation *
            Quaternion.Euler(0f, 0f, -overshootAmount * direction);

        // --------------------------------
        // 1. SZYBKI OBRÓT
        // --------------------------------

        while (time < duration * 0.35f)
        {
            time += Time.deltaTime;

            float t = time / (duration * 0.35f);

            // Mocno przyspieszone wejœcie
            t = 1f - Mathf.Pow(1f - t, 3f);

            transform.localRotation = Quaternion.Lerp(
                start,
                rotate,
                t
            );

            yield return null;
        }

        // --------------------------------
        // 2. PRZECHYLENIE W DRUG¥ STRONÊ
        // --------------------------------

        time = 0f;

        while (time < duration * 0.25f)
        {
            time += Time.deltaTime;

            float t = time / (duration * 0.25f);

            t = Mathf.SmoothStep(0f, 1f, t);

            transform.localRotation = Quaternion.Lerp(
                rotate,
                overshoot,
                t
            );

            yield return null;
        }

        // --------------------------------
        // 3. POWRÓT DO NORMALNEJ POZYCJI
        // --------------------------------

        time = 0f;

        while (time < duration * 0.4f)
        {
            time += Time.deltaTime;

            float t = time / (duration * 0.4f);

            t = Mathf.SmoothStep(0f, 1f, t);

            transform.localRotation = Quaternion.Lerp(
                overshoot,
                originalRotation,
                t
            );

            yield return null;
        }

        transform.localRotation = originalRotation;
        animationCoroutine = null;
    }
}