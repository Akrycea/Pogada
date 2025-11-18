using UnityEngine;
using UnityEngine.UIElements;

public class Przeszkody : MonoBehaviour
{
    public bool state;

    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (gameObject.CompareTag("ZGpassable"))
        {
            state = true;
        }

        if (gameObject.CompareTag("ZGnotpassable"))
        {
            state = false;
        }
    }


    void Update()
    {
        if (state)
        {
            gameObject.tag = "ZGpassable";
            spriteRenderer.sprite = spriteArray[0];
        }

        if (!state)
        {
            gameObject.tag = "ZGnotpassable";
            spriteRenderer.sprite = spriteArray[1];
        }
    }

    private void OnMouseDown()
    {
        state = !state;
    }
}
