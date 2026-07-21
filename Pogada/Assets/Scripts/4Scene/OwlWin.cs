using TMPro.Examples;
using UnityEngine;

public class OwlWin : MonoBehaviour
{
    public GameObject OwlOnUI;

    [SerializeField]
    private GameObject colliders;

    [SerializeField] private Transform player;
    [SerializeField] private Transform teleport;

    private void OnMouseDown()
    {
        Debug.Log("OwlWin Click");

        if (OwlOnUI.activeInHierarchy == true)
        {
            //win
            OwlOnUI.SetActive(false);
            colliders.SetActive(false);
            //tutaj przenies do nastepnej sceny

            player.position = teleport.position;

        }
    }
}
