using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class StatueControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] sunParts;
    [SerializeField]
    private GameObject[] moonParts;

    [SerializeField]
    private int sunNumber = 0;
    [SerializeField]
    private int moonNumber = 0;

    public StateManager stateManager;

    private DialogueRunner dialogueRunner;
    [SerializeField]
    private GameObject Czerwony;

    public void StatusSun()
    {
        if (sunParts[sunNumber].CompareTag("Free") && sunNumber < sunParts.Length)
        {
            sunNumber++;
            sunParts[sunNumber].SetActive(true);
            sunParts[sunNumber].tag = "Free";
            StatusWin();
        }
    }

    public void StatusMoon()
    {
        if (moonParts[moonNumber].CompareTag("Free") && moonNumber < moonParts.Length)
        {
            moonNumber++;
            moonParts[moonNumber].SetActive(true);
            moonParts[moonNumber].tag = "Free";
            StatusWin();
        }
    }

   public void StatusWin()
    {
        if (sunNumber == sunParts.Length - 1 && moonNumber == moonParts.Length - 1)
        {
            dialogueRunner = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
            dialogueRunner.StartDialogue("P3_Statua_fin");
            //dialogueRunner.StartDialogue("D7_PoznanieCzerwieni");
            Czerwony.SetActive(true);
        }
    }
}
