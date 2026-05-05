using UnityEditor;
using UnityEngine;

public class PuzzleMinigame : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    //tu dajemyy sprite obiektu ktorego przenosimy/jaki chcemy by sie ustawil, bo dziala to tak, ze zamiast ustawiac tamten obiekt, to usuwa go i zmienia sprite tego na ten
    public Sprite targetSprite;

    //obiekt ktory przenosimy
    public GameObject ogObject;

    public string ObjectName;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ObjectName)
        {
            spriteRenderer.sprite = targetSprite;
            ogObject.SetActive(false);
        }
    }
}
