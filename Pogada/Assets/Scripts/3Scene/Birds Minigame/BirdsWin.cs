using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class BirdsWin : MonoBehaviour
{
    //changed for public JUST FOR DEMO FOR TOMEK
    [SerializeField]public int birdsWin;

    public DialogueRunner dialogueRunner;

    public GameObject BlueprintUI;

    //changed for public JUST FOR DEMO FOR TOMEK
    [SerializeField]public bool dialoguePlayed = false;

    public StateManager stateManager;


    public void GoodSpot()
    {
        birdsWin++;
    }

    public void BadSpot()
    {
        birdsWin--;
    }

    [YarnCommand("ShowBlueprintsOnUI")]
    public void BlueprintsUI()
    {
       BlueprintUI.SetActive(true);
    }

    public void Update()
    {

        if (birdsWin == 5 && Input.GetMouseButton(0) == false && dialoguePlayed == false)
        {
            Debug.Log("birds won");
            dialogueRunner.StartDialogue("D3_PtakiWygrana");
            dialoguePlayed = true;
            stateManager.BirdMinigameWon = true;

            //turning it off so the if doesnt get checked after winning the minigame
            //to save memory
            gameObject.GetComponent<BirdsWin>().enabled = false;

        }
    }
}
