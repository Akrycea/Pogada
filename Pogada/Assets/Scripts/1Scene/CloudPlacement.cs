using TMPro.Examples;
using UnityEngine;

public class CloudPlacement : MonoBehaviour
{

    //tu dajemyy sprite obiektu ktorego przenosimy/jaki chcemy by sie ustawil, bo dziala to tak, ze zamiast ustawiac tamten obiekt, to usuwa go i zmienia sprite tego na ten
    public Sprite targetSprite;

    [HideInInspector]
    public SpriteRenderer spriteRenderer;


    private CloudStairsMinigame stairsMinigame;

    public bool alreadyFilled = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        stairsMinigame = GameObject.Find("StairsCloudMinigame").GetComponent<CloudStairsMinigame>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (alreadyFilled == false) 
        {
            Debug.Log("false dziala");

            if (collision.CompareTag("cloud"))
            {
                spriteRenderer.sprite = targetSprite;
                collision.gameObject.SetActive(false);
                stairsMinigame.doneSteps++;
                alreadyFilled = true;
            }
        }
    }
}
