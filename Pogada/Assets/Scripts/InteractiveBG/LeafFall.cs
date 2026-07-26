using UnityEngine;

public class LeafFall : MonoBehaviour
{
    public float fallSpeed = 2f;      // prêdkoœæ opadania
    public float swayAmount = 0.5f;   // jak mocno ko³ysze siê na boki
    public float swaySpeed = 3f;      // szybkoœæ ko³ysania
    public float rotationSpeed = 90f; // obrót liœcia

    private float randomOffset;

    void Start()
    {
        randomOffset = Random.Range(0f, 100f);

        // usuñ liœæ po 5 sekundach
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        // opadanie
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        // ko³ysanie na boki
        float x = Mathf.Sin(Time.time * swaySpeed + randomOffset) * swayAmount;
        transform.position += Vector3.right * x * Time.deltaTime;

        // obrót
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}