using System.Collections;
using UnityEngine;

public class ZnikanieObiektow : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    //poziom naszego znikania
    float alphaLevel;
    //czy couroutine isrunning, nwm bez tego robi kilka naraz
    bool isRunning = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        alphaLevel = 1f;
    }

  
    void Update()
    {
        //to kontroluje przezroczystosc naszego obiektu
        spriteRenderer.color = new Color(1f, 1f, 1f, alphaLevel);

        //jesli przezroczystosc jest mniejsza lub rowna zera usun obiekt
        if (alphaLevel <= 0f)
        {
            Destroy(gameObject);
        }
    }


    //jak jest myszka na obiekcie to zaczyna couroutine
    void OnMouseOver()
    {
        if (!isRunning) StartCoroutine(Wait());
    }

    //couroutina odpowiadajaca za powolne znikanie obiektu
    IEnumerator Wait()
    {
        isRunning = true;
        alphaLevel = alphaLevel -0.1f;
        yield return new WaitForSeconds(0.1f);
        isRunning = false;
    }
}
