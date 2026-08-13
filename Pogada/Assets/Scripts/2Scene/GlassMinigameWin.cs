using UnityEngine;
using Yarn.Unity;

public class GlassMinigameWin : MonoBehaviour
{

    [SerializeField] private int glassWin;

    public DialogueRunner dialogueRunner;

    private bool dialoguePlayed = false;

    public StateManager stateManager;

    public GameObject Fiolt;


    public void GoodSpot()
    {
        glassWin++;

        if (glassWin == 4)
        {
            Debug.Log("glass won");
            //Fiolt.SetActive(true);
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
