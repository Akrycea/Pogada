using System.Collections;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class UniwersalnySpriteChanger : MonoBehaviour
{ 
    // robisz array na tyle ile spriteow ma byc i wkladasz je, pamietajac ze skrypt idzie po kolei oraz zaznaczasz czy chcesz by sprites sie loopowaly, czy konczyly na ostatnim
    
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    int CurrentSprite;
    public bool LoopSprites;
    public bool EndSprites;
    public bool PrzenosPrzedmiotyPoEndSprites;

    public PrzenoszeniePrzedmiotow przenoszeniePrzedmiotow;

    public Transform player;

    void Start()
    {
        CurrentSprite = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();//odniesienie do gracza

        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnMouseDown()
    {
        if (EndSprites && CurrentSprite < spriteArray.Length - 1)
        {
            CurrentSprite = CurrentSprite + 1;
            spriteRenderer.sprite = spriteArray[CurrentSprite];
            
        } 

        if (LoopSprites)
        {
            CurrentSprite = CurrentSprite + 1;
            spriteRenderer.sprite = spriteArray[CurrentSprite];

            if (CurrentSprite == spriteArray.Length - 1)
            {
                CurrentSprite = -1;
            }
        }
    }

    private void Update()
    {
        if (PrzenosPrzedmiotyPoEndSprites && EndSprites && CurrentSprite == spriteArray.Length - 1)
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {  
        yield return new WaitForSeconds(0.1f);
        przenoszeniePrzedmiotow.ZezwolPrzenoszenie = true;
    }
}
