using TMPro.Examples;
using UnityEngine;

public class OwlWin : MonoBehaviour
{
    public GameObject OwlOnUI;

    [SerializeField]
    private GameObject colliders;

    private void OnMouseDown()
    {
        if(OwlOnUI.activeInHierarchy == true)
        {
            //win
            OwlOnUI.SetActive(false);
            colliders.SetActive(false);
            //tutaj przenies do nastepnej sceny
        }
    }
}
