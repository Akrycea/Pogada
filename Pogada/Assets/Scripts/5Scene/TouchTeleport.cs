using UnityEngine;
using System.Collections;

public class TouchTeleport : MonoBehaviour
{
    [SerializeField] private EditCamera editCameraScript;
    [SerializeField] private Transform player;
    [SerializeField] private Transform teleport;

    [SerializeField] private GameObject blackoutCanvas;
    [SerializeField] private Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(changeScene());
    }
    IEnumerator changeScene()
    {
        blackoutCanvas.SetActive(true);
        anim.Play("BlackoutIn");
        yield return new WaitForSeconds(1);

        //tutaj przenies do nastepnej sceny
        player.position = teleport.position;
        editCameraScript.ChangeCamera();

        yield return new WaitForSeconds(2);

        anim.Play("BlackoutOut");
        yield return new WaitForSeconds(1);
        blackoutCanvas.SetActive(false);
    }
}
