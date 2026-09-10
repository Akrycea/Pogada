using System.Collections;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public FishWon fishWon;

    public GameObject fishOnUI;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        StartCoroutine(takingFish());
    }

    IEnumerator takingFish()
    {
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(2f);
        fishWon.FishWin();
        gameObject.SetActive(false);
        fishOnUI.SetActive(true);
    }
}
