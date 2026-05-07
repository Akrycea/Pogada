using UnityEngine;

public class Fish : MonoBehaviour
{
    public FishWon fishWon;

    public GameObject fishOnUI;

    private void OnMouseDown()
    {
        fishWon.FishWin();
        gameObject.SetActive(false);
        fishOnUI.SetActive(true);
    }
}
