using UnityEngine;

public class ChangingColors : MonoBehaviour
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
        if(colorChange.szary == true)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (colorChange.zielony == true)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (colorChange.czerwony == true)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (colorChange.granat == true)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if (colorChange.pomarancz == true)
        {
            spriteRenderer.sprite = sprites[4];
        }
        else if (colorChange.niebieski == true)
        {
            spriteRenderer.sprite = sprites[5];
        }
        else if (colorChange.fiolet == true)
        {
            spriteRenderer.sprite = sprites[6];
        }
        else if (colorChange.zolty == true)
        {
            spriteRenderer.sprite = sprites[7];
        }
    }
}
