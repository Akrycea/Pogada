using UnityEngine;
using Yarn.Unity;

public class GlassMinigameWin : MonoBehaviour
{

    private int glassWin;

    public DialogueRunner dialogueRunner;

    private bool dialoguePlayed = false;

    public StateManager stateManager;

    public GameObject Fiolt;


    public void GoodSpot()
    {
        glassWin++;

        if (glassWin == 5 && Input.GetMouseButton(0) == false && dialoguePlayed == false)
        {
            Debug.Log("glass won");
            Fiolt.SetActive(true);
            stateManager.GlassMinigameWon = true;
            //DBATA HR
            //dialogueRunner.StartDialogue("");
            //dialoguePlayed = true;


        }
    }

    public void BadSpot()
    {
        glassWin--;
    }
}
