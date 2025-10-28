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

    //odniesienie do licznika chmur
    public ChmuryMinigierka chMinigierka;

    //odniesienie do gracza
    public Transform player;

    private void Start()
    {
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

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
        chMinigierka.doneSteps++;
    }

}
