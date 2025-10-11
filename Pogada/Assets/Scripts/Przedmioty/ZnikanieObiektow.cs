using System.Collections;
using UnityEngine;

public class ZnikanieObiektow : MonoBehaviour
{
    //poziom naszego znikania
    float alphaLevel;
    public SpriteRenderer spriteRenderer;
    bool isRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        alphaLevel = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, alphaLevel);
    }

    void OnMouseOver()
    {
        if (!isRunning) StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        isRunning = true;
        alphaLevel = alphaLevel -0.1f;
        Debug.Log("myszka jest na obiekcie:D");
        yield return new WaitForSeconds(0.1f);
        isRunning = false;
    }
}
