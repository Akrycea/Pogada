using UnityEngine;
using System.Collections;

public class CartoonSpin : MonoBehaviour
{
    [Header("Spin Settings")]
    [SerializeField] private float rotationSpeed = 0.35f;
    [SerializeField] private int rotations = 1;

    private Coroutine spinCoroutine;

    private void OnMouseDown()
    {
        if (spinCoroutine != null)
            StopCoroutine(spinCoroutine);

        spinCoroutine = StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        float duration = rotationSpeed;
        float time = 0f;

        float startAngle = transform.localEulerAngles.z;
        float totalRotation = 360f * rotations;

        while (time < duration)
        {
            time += Time.deltaTime;

            float t = time / duration;

            // Cartoonowe przyspieszenie i wyhamowanie
            float easedT = EaseInOutBack(t);

            float angle = startAngle + totalRotation * easedT;

            transform.localRotation = Quaternion.Euler(
                0f,
                0f,
                angle
            );

            yield return null;
        }

        // Dok³adnie koñczymy na pozycji startowej
        transform.localRotation = Quaternion.Euler(
            0f,
            0f,
            startAngle
        );

        spinCoroutine = null;
    }

    private float EaseInOutBack(float t)
    {
        float c1 = 1.70158f;
        float c2 = c1 * 1.525f;

        return t < 0.5f
            ? (Mathf.Pow(2f * t, 2f) *
               ((c2 + 1f) * 2f * t - c2)) / 2f
            : (Mathf.Pow(2f * t - 2f, 2f) *
               ((c2 + 1f) * (t * 2f - 2f) + c2) + 2f) / 2f;
    }
}
