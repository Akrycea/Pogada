using TMPro.Examples;
using UnityEngine;

public class OwlWin : MonoBehaviour
{
    public GameObject OwlOnUI;

    [SerializeField]
    private GameObject colliders;

    [SerializeField] Transform playerTransform;
    [SerializeField] Transform teleport;

    private void OnMouseDown()
    {
        Debug.Log("Clicked on bush");
        if(OwlOnUI.activeInHierarchy == true)
        {
            //win
            OwlOnUI.SetActive(false);
            colliders.SetActive(false);
            //tutaj przenies do nastepnej sceny
            playerTransform.position = teleport.position;

            Debug.Log("Owl win");
        }
    }
}
