using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class FioletDisappearing : MonoBehaviour
{
    [SerializeField] private GameObject fiolet;
    [SerializeField] private KidRunAway fioletRunAway;

    private bool done = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "InteractionsBohater" && done == false)
        {
            fioletRunAway.kidRunAway();
            StartCoroutine(WaitRunAway());
        }

        IEnumerator WaitRunAway()
        {
            yield return new WaitForSeconds(5);
            fiolet.SetActive(false);
            done = true;
        }
    }

}

