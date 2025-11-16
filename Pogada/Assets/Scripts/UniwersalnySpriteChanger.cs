using System.Collections;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class UniwersalnySpriteChanger : MonoBehaviour
{
    // robisz array na tyle ile spriteow ma byc i wkladasz je, pamietajac ze skrypt idzie po kolei oraz zaznaczasz czy chcesz by sprites sie loopowaly, czy konczyly na ostatnim

    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    //tablica ze sprite'ami
    public Sprite[] spriteArray;

    //liczba na ktorym sprite jestes
    int CurrentSprite;

    //wybierasz ktory typ chcesz
    public bool LoopSprites;
    public bool EndSprites;

    //czy chcesz by po end sprites mozna bylo je przenosic
    public bool PrzenosPrzedmiotyPoEndSprites;

    //refrence do skryptu z przenoszeniem przedmiotow
    public PrzenoszeniePrzedmiotow przenoszeniePrzedmiotow;

    //gracz
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    private bool allowSpriteChange = true;

    void Start()
    {
        CurrentSprite = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();

        //odniesienie do gracza
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnMouseDown()
    {
        if (allowSpriteChange)
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
        allowSpriteChange = false;
        yield return new WaitForSeconds(0.5f);
        przenoszeniePrzedmiotow.ZezwolPrzenoszenie = true;
    }
}
