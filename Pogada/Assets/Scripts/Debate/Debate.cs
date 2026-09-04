using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Debate : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;

    public int YourPoints;
    public int EnemyPoints;

    //numer debaty (kolejnosc chronologiczna)
    public int debateNumber = 0;

    public StateManager stateManager;
    public DialogueRunner dialogueRunner;

    public DebateManager debateManager;

    public Slider debateSlider;
    public Slider enemySlider;

    [SerializeField] private TurnOffCollider turnOffCollider;

    [YarnCommand("Ending")]
    public void Ending()
    {

        if (debateNumber == 1)
        {
            stateManager.Violaceus1DebateWon = true;
            dialogueRunner.StartDialogue("M1_PoznanieFioletPoDebacie");
            debateManager.EndDebate();
        }

        if (YourPoints > EnemyPoints)
        {
            Debug.Log("you won");
            //checks which debate is active and activates the appropriate color

        
            if (debateNumber == 2)
            {
                stateManager.ViriDebateWon = true;
                dialogueRunner.StartDialogue("M15_DebataZielieniPoDebata");
                stateManager.szary = false;
                stateManager.zielony = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 3) 
            {
                stateManager.RobertDebateWon = true;
                dialogueRunner.StartDialogue("M2_PoznanieCzerwieniPoDebata");
                stateManager.zielony = false;
                stateManager.czerwony = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 4)
            {
                stateManager.LivDebateWon = true;
                dialogueRunner.StartDialogue("M3_PogodzenieGranatPoDebata");
                stateManager.czerwony = false;
                stateManager.granat = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 5)
            {
                stateManager.LuteDebateWon = true;
                dialogueRunner.StartDialogue("M31_DebataPomaranczPoDebata");
                stateManager.granat = false;
                stateManager.pomarancz = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 6)
            {
                stateManager.LusDebateWon = true;
                dialogueRunner.StartDialogue("M31_DebataBlekitPoDebata");
                stateManager.pomarancz = false;
                stateManager.niebieski = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 7)
            {
                stateManager.Violaceus2DebateWon = true;
                dialogueRunner.StartDialogue("M4_DebataFioletPoDebata");
                stateManager.niebieski = false;
                stateManager.fiolet = true;
                debateManager.EndDebate();
            }
            else if (debateNumber == 8)
            {
                stateManager.AureusDebateWon = true;
                dialogueRunner.StartDialogue("M5_DebataZolcPoDebata");
                stateManager.fiolet = false;
                stateManager.zolty = true;
                debateManager.EndDebate();
            }
        }

        if (EnemyPoints > YourPoints || EnemyPoints == YourPoints && debateNumber > 1)
        {
            Debug.Log("you lost");
            debateNumber = debateNumber--;
            playerMovement.canPlayerMove = true;
            turnOffCollider.EnableAllColliders();
        }

        YourPoints = 0;
        EnemyPoints = 0;
        UpdateDebateSliders();
    }

    // kids points! 10 is max 
    [YarnCommand("SetKidPoints")]
    public void SetKidPoints(int points)
    {
        EnemyPoints = points;
        UpdateDebateSliders();
    }

    //updates the debate number so the debate script knows WHICH debate is currently playing
    [YarnCommand("UpdateDebateNumber")]
    public void UpdateDebateNumber()
    {
        Debug.Log("changing debate number to: " + debateNumber);
        debateNumber++;
    }

    //debate yarn commands

    [YarnCommand("GoodChoice")]
    public void GoodChoice()
    {  
        YourPoints += 1;
        UpdateDebateSliders();
    }

    [YarnCommand("BadChoice")]
    public void BadChoice()
    {     
        EnemyPoints += 1;
        UpdateDebateSliders();
    }

    [YarnCommand("VGoodChoice")]
    public void VGoodChoice()
    {
        YourPoints += 2;
        UpdateDebateSliders();

    }

    [YarnCommand("VBadChoice")]
    public void VBadChoice()
    {
        EnemyPoints += 2;
        UpdateDebateSliders();
    }

    public void UpdateDebateSliders()
    {
        debateSlider.value = YourPoints;
        enemySlider.value = EnemyPoints;
    }

}
