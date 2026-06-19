using UnityEngine;
using Yarn.Unity;

public class FishWon : MonoBehaviour
{
    public int allFish;
    public bool allFishFound;

    private ClickDialogue granat;

    private bool done = false;

    public StateManager stateManager;

    [SerializeField]
    private DialogueRunner dialogueRunner;


    public void FishWin()
    {
        allFish++;

        if (allFish == 5)
        {
            allFishFound = true;
            stateManager.FishMinigameWon = true;
            Debug.Log("Fish Minigame Won");

            granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
            granat.nazwaDialogu = "D8_5RybkiGranat";
            granat.dialoguePlayed = false;
            dialogueRunner.StartDialogue("P4_Rybki_fin");
        }
    }
}
