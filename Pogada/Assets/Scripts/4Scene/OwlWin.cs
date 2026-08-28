using System.Collections;
using TMPro.Examples;
using UnityEngine;

public class OwlWin : MonoBehaviour
{
    public GameObject OwlOnUI;

    [SerializeField]
    private GameObject colliders;

    [SerializeField] private Transform player;
    [SerializeField] private Transform teleport;
    [SerializeField] private EditCamera editCamera;

    [SerializeField] private GameObject blackoutCanvas;
    [SerializeField] private Animator anim;

    private void OnMouseDown()
    {
        Debug.Log("OwlWin Click");

        //if (//OwlOnUI.activeInHierarchy == true)
        //{
            //win
            OwlOnUI.SetActive(false);
            colliders.SetActive(false);

            //tutaj przenies do nastepnej sceny
            //player.position = teleport.position;
            //editCamera.ChangeCamera();

        StartCoroutine(changeScene());


        //}
    }

    IEnumerator changeScene()
    {
        blackoutCanvas.SetActive(true);
        anim.Play("BlackoutIn");
        yield return new WaitForSeconds(1);

        //tutaj przenies do nastepnej sceny
        player.position = teleport.position;
        editCamera.ChangeCamera();

        yield return new WaitForSeconds(2);

        anim.Play("BlackoutOut");
        yield return new WaitForSeconds(1);
        blackoutCanvas.SetActive(false);
    }
}
