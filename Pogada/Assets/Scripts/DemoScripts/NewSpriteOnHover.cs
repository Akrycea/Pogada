using UnityEngine;

public class NewSpriteOnHover : MonoBehaviour
{
    void Start()
    {
        gameObjectSprite = GetComponent<SpriteRenderer>();
        gameObjectSprite.sprite = sprites[0];
    }

    [SerializeField]
    private Sprite[] sprites;

    private SpriteRenderer gameObjectSprite;

    private void OnMouseOver()
    {
        gameObjectSprite.sprite = sprites[1];
    }

    private void OnMouseExit()
    {
        gameObjectSprite.sprite = sprites[0];
    }
}
