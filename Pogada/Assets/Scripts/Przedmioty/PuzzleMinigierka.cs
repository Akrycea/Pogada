using UnityEngine;

public class PuzzleMinigierka : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    //tu dajemyy sprite obiektu ktorego przenosimy/jaki chcemy by sie ustawil, bo dziala to tak, ze zamiast ustawiac tamten obiekt, to usuwa go i zmienia sprite tego na ten
    public Sprite DocelowySprite;
    //obiekt ktory przenosimy
    public GameObject ObiektOrginalny;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Puzzle()
    { 
        spriteRenderer.sprite = DocelowySprite;
        ObiektOrginalny.SetActive(false);
    }
}
