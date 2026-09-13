using System.Collections;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public FishWon fishWon;

    public GameObject fishOnUI;

    private SpriteRenderer spriteRenderer;

    [SerializeField] private bool LockFishB4red = false;

    public StateManager stateManager;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        if (LockFishB4red && stateManager.czerwony == true)
        {
            StartCoroutine(takingFish());
        }
        else if (LockFishB4red == false)
        {
            StartCoroutine(takingFish());
        }
       
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
