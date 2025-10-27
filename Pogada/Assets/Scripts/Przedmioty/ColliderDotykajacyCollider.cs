using TMPro.Examples;
using UnityEngine;

public class ColliderDotykajacyCollider : MonoBehaviour
{
    public string ObjectName;
    public bool KluczMinigierka;
    public bool ChmuryMinigierka;

    public SpriteRenderer spriteRenderer;
    public Sprite DocelowySprite;
    public GameObject ObiektOrginalny;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == ObjectName)
        {
            Debug.Log("yay");

            if (ChmuryMinigierka)
            {
                Chmury();
            }
        }

    }

    void Chmury()
    {
        spriteRenderer.sprite = DocelowySprite;
        ObiektOrginalny.SetActive(false);
    }

}
