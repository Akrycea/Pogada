using UnityEngine;
using Yarn.Unity;

public class Debate : MonoBehaviour
{
    public int YourPoints;
    public int EnemyPoints;

    //numer debaty (kolejnosc chronologiczna)
    public int debateNumber = 0;

    public StateManager stateManager;
    public DialogueRunner dialogueRunner;

    [YarnCommand("Ending")]
    public void Ending()
    {
        if (YourPoints > EnemyPoints)
        {
            Debug.Log("you won");
            //checks which debate is active and activates the appropriate color
            if(debateNumber == 1)
            {
                stateManager.Violaceus1DebateWon = true;
                dialogueRunner.StartDialogue("M1_PoznanieFioletPoDebacie");
            }
            else if (debateNumber == 2)
            {
                stateManager.ViriDebateWon = true;
                dialogueRunner.StartDialogue("M15_DebataZielieniPoDebata");
                stateManager.szary = false;
                stateManager.zielony = true;
            }
            else if (debateNumber == 3) 
            {
                stateManager.RobertDebateWon = true;
                dialogueRunner.StartDialogue("M2_PoznanieCzerwieniPoDebata");
                stateManager.zielony = false;
                stateManager.granat = true;
            }
            else if (debateNumber == 4)
            {
                stateManager.LivDebateWon = true;
                dialogueRunner.StartDialogue("M3_PogodzenieGranatPoDebata");
                stateManager.granat = false;
                stateManager.czerwony = true;
            }
            else if (debateNumber == 5)
            {
                stateManager.LuteDebateWon = true;
                dialogueRunner.StartDialogue("M31_DebataPomaranczPoDebata");
                stateManager.czerwony = false;
                stateManager.pomarancz = true;
            }
            else if (debateNumber == 6)
            {
                stateManager.LusDebateWon = true;
                dialogueRunner.StartDialogue("M31_DebataBlekitPoDebata");
                stateManager.pomarancz = false;
                stateManager.niebieski = true;
            }
            else if (debateNumber == 7)
            {
                stateManager.Violaceus2DebateWon = true;
                dialogueRunner.StartDialogue("M4_DebataFioletPoDebata");
                stateManager.niebieski = false;
                stateManager.fiolet = true;
            }
            else if (debateNumber == 8)
            {
                stateManager.AureusDebateWon = true;
                dialogueRunner.StartDialogue("M5_DebataZolcPoDebata");
                stateManager.fiolet = false;
                stateManager.zolty = true;
            }
            YourPoints = 0;
        }

        if (EnemyPoints > YourPoints)
        {
            Debug.Log("you lost");
            YourPoints = 0;
            debateNumber = debateNumber--;
        }
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
    }

    [YarnCommand("BadChoice")]
    public void BadChoice()
    {
        EnemyPoints += 1;
    }

    [YarnCommand("VGoodChoice")]
    public void VGoodChoice()
    {
        YourPoints += 2;
    }

    [YarnCommand("VBadChoice")]
    public void VBadChoice()
    {
        EnemyPoints += 2;
    }


    
}
