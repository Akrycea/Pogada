using UnityEngine;

public class ChangingColors : MonoBehaviour
{
    public StateManager stateManager;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if(stateManager.szary == true)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (stateManager.zielony == true)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (stateManager.czerwony == true)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (stateManager.granat == true)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if (stateManager.pomarancz == true)
        {
            spriteRenderer.sprite = sprites[4];
        }
        else if (stateManager.niebieski == true)
        {
            spriteRenderer.sprite = sprites[5];
        }
        else if (stateManager.fiolet == true)
        {
            spriteRenderer.sprite = sprites[6];
        }
        else if (stateManager.zolty == true)
        {
            spriteRenderer.sprite = sprites[7];
        }
    }
}
