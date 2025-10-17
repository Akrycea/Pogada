using Unity.Burst.Intrinsics;
using UnityEngine;

public class UniwersalnySpriteChanger : MonoBehaviour
{ 
    // robisz array na tyle ile spriteow ma byc i wkladasz je, pamietajac ze skrypt idzie po kolei oraz zaznaczasz czy chcesz by sprites sie loopowaly, czy konczyly na ostatnim
    
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    int CurrentSprite = 0;
    public bool LoopSprites;
    public bool EndSprites;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        if (EndSprites && CurrentSprite == spriteArray.Length - 2)
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
}
