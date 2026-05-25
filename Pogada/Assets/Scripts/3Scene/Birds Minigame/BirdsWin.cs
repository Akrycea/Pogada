using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class BirdsWin : MonoBehaviour
{
    [SerializeField]private int birdsWin;

    public DialogueRunner dialogueRunner;

    public GameObject BlueprintUI;

    [SerializeField]private bool dialoguePlayed = false;

    public StateManager stateManager;


    public void GoodSpot()
    {
        birdsWin++;

        //wasnt working,commenting other ifs is a temporary solution for the demo
        if (birdsWin == 5)// && Input.GetMouseButton(0) == false && dialoguePlayed == false)
        {
            Debug.Log("birds won");
            dialogueRunner.StartDialogue("D3_PtakiWygrana");
            dialoguePlayed = true;
            stateManager.BirdMinigameWon = true;

        }
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
}
