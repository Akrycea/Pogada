using UnityEngine;

public class SpriteChangeAfterPuzzle : MonoBehaviour
{
    //array do psrites przed i po ukonczeniu puzzla
    public Sprite[] objectSprites;

    //sprite renderer obiektu na ktorym znajduje sie skrypt
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        //ustawia 1 sprite na start - przed rozwiazaniem zagadki
        spriteRenderer.sprite = objectSprites[0];
    }

    public void myPuzzleGotCompleted()
    {
        //ustawia 2 sprite - po rozwiazaniu zagadki
        spriteRenderer.sprite = objectSprites[1];
    }
}
