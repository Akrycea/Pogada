using UnityEngine;

public class FishWon : MonoBehaviour
{
    public int allFish;
    public bool allFishFound;

    private ClickDialogue granat;

    private bool done = false;

    public StateManager stateManager;


    public void FishWin()
    {
        allFish++;

        if (allFish == 4)
        {
            allFishFound = true;
            stateManager.FishMinigameWon = true;
            Debug.Log("Fish Minigame Won");

            granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
            granat.nazwaDialogu = "D8_5RybkiGranat";
            granat.dialoguePlayed = false;
        }
    }
}
