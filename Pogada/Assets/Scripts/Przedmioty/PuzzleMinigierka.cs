using UnityEngine;

public class PuzzleMinigierka : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite DocelowySprite;
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
