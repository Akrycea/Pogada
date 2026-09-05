using UnityEngine;
using Yarn.Unity;

public class GlassMinigameWin : MonoBehaviour
{

    [SerializeField] private int glassWin;

    public StateManager stateManager;

    [SerializeField] private DebataPlayer debataPlayer;

    public DialogueRunner dialogueRunner;

    [SerializeField] private GameObject Violaceus;


    public void GoodSpot()
    {
        glassWin++;

        if (glassWin == 4)
        {
            Debug.Log("glass won");
            stateManager.GlassMinigameWon = true;
            debataPlayer.wygranaMinigierka = true;
            dialogueRunner.StartDialogue("P7_DrzwiFiolet_fin");

            Violaceus.SetActive(true);
        }
    }

    public void BadSpot()
    {
        glassWin--;
    }
}
