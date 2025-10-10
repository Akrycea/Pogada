using Unity.VisualScripting;
using UnityEngine;

public class ObjectSprites : MonoBehaviour
{
    public ColorChange colorChange;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (colorChange.szary)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (colorChange.zielony)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (colorChange.czerwony)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (colorChange.granat)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if (colorChange.pomarancz)
        {
            spriteRenderer.sprite = sprites[4];
        }
        else if (colorChange.niebieski)
        {
            spriteRenderer.sprite = sprites[5];
        }
        else if (colorChange.fiolet)
        {
            spriteRenderer.sprite = sprites[6];
        }
        else if (colorChange.zolty)
        {
            spriteRenderer.sprite = sprites[7];
        }
    }
}
