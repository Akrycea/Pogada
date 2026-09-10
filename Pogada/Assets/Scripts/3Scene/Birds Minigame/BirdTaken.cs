using System.Collections;
using UnityEngine;

public class BirdTaken : MonoBehaviour
{
    public ClickDialogue clickDialogue;
    public GameObject BirdOnUI;
    [SerializeField] ObjectSFX sfx;
    void Update()
    {
        if (clickDialogue.dialoguePlayed == true)
        {
            StartCoroutine(takingBirb());
        }
    }
    private BirdsWin bMinigame;

    IEnumerator takingBirb()
    {
        sfx.playSFX();
        yield return new WaitForSeconds(1f);
        BirdOnUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
