using TMPro.Examples;
using UnityEngine;

public class OwlWin : MonoBehaviour
{
    public GameObject OwlOnUI;

    private void OnMouseDown()
    {
        if(OwlOnUI.activeInHierarchy == true)
        {
            //win
            OwlOnUI.SetActive(false);
            //tutaj przenies do nastepnej sceny
        }
    }
}
