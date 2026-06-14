using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class StatueControl : MonoBehaviour
{
    public GameObject ground;
    public GameObject[] sunParts;
    public GameObject[] moonParts;

    [SerializeField]
    private int sunNumber = 0;
    [SerializeField]
    private int moonNumber = 0;

    //public DebataPlayer debataPlayer;

    //public BirdsWin birsWin;

    public GameObject SunHead;
    public GameObject MoonHead;

    //birdOnUI.activeInHierarchy

    //gameObject.CompareTag("")

    private DialogueRunner dialogueRunner;

    public GameObject Czerwony;

    public StateManager stateManager;

    public void Status()
    {
        if (sunParts[sunNumber].CompareTag("Free") && sunNumber < sunParts.Length - 1)
        {
            sunNumber++;
            sunParts[sunNumber].SetActive(true);
            sunParts[sunNumber].tag = "Free";
        }

        if (moonParts[moonNumber].CompareTag("Free") && moonNumber < moonParts.Length - 1)
        {
            moonNumber++;
            moonParts[moonNumber].SetActive(true);
            moonParts[moonNumber].tag = "Free";
        }


        if (SunHead.activeInHierarchy == false && MoonHead.activeInHierarchy == false)
        {
            Debug.Log("statuly wygrane");
            //debataPlayer.wygranaMinigierka = true;

            dialogueRunner = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
            dialogueRunner.StartDialogue("D7_PoznanieCzerwieni");
            Czerwony.SetActive(true);

        }
    }
}
