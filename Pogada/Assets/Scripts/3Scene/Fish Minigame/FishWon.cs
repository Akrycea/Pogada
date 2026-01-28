using UnityEngine;

public class FishWon : MonoBehaviour
{
    public int allFish;
    public bool allFishFound;

    public GameObject allFishOnUI;

    private ClickDialogue granat;

    private bool done = false;

    void Update()
    {
        if (allFish == 4 && done == false)
        {
            allFishFound = true;
            Debug.Log("Fish Minigame Won");

            granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
            granat.nazwaDialogu = "D8_5RybkiGranat";
            granat.dialoguePlayed = false;

            done = true;
        }
    }
}
