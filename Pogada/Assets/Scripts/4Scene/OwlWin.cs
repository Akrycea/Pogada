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

    public StateManager stateManager;

    //[SerializeField] private GameObject OwlObject;

    private void OnMouseDown()
    {
        Debug.Log("OwlWin Click");
        //tutaj przenies do nastepnej sceny
        //player.position = teleport.position;
        //editCamera.ChangeCamera();

        if (stateManager.LuteDebateWon)
        {
            StartCoroutine(changeScene());
        }
    }

    IEnumerator changeScene()
    {
        OwlOnUI.SetActive(false);
        colliders.SetActive(false);

        blackoutCanvas.SetActive(true);
        anim.Play("BlackoutIn");
        yield return new WaitForSeconds(1);

        //tutaj przenies do nastepnej sceny
        player.position = teleport.position;
        ChangeCamera();

        yield return new WaitForSeconds(2);

        anim.Play("BlackoutOut");
        yield return new WaitForSeconds(1);
        blackoutCanvas.SetActive(false);

        //OwlObject.SetActive(true);
    }

    [SerializeField] private GameObject nextCamera;
    public void ChangeCamera()
    {
        if (nextCamera.activeSelf == false)
        {
            nextCamera.SetActive(true);
        }
        else if (nextCamera.activeSelf == true)
        {
            nextCamera.SetActive(false);
        }
    }
}
