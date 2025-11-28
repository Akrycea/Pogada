using UnityEngine;

public class PuzzleMinigame : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    //tu dajemyy sprite obiektu ktorego przenosimy/jaki chcemy by sie ustawil, bo dziala to tak, ze zamiast ustawiac tamten obiekt, to usuwa go i zmienia sprite tego na ten
    public Sprite targetSprite;

    //obiekt ktory przenosimy
    public GameObject ogObject;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Puzzle()
    { 
        spriteRenderer.sprite = targetSprite;
        ogObject.SetActive(false);
    }
}
