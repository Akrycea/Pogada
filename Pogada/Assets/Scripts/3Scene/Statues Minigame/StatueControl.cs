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

    public BirdsWin birsWin;

    public GameObject SunHead;
    public GameObject MoonHead;

    //birdOnUI.activeInHierarchy

    //gameObject.CompareTag("")

    private DialogueRunner dialogueRunner;

    public GameObject Czerwony;

    public void Status()
    {
        if (sunParts[sunNumber].CompareTag("CZplaceable") && sunNumber < sunParts.Length - 1 && birsWin.birdsWin == 5)
        {
            sunNumber++;
            sunParts[sunNumber].SetActive(true);
        }

        if (moonParts[moonNumber].CompareTag("CZplaceable") && moonNumber < moonParts.Length - 1 && birsWin.birdsWin == 5)
        {
            moonNumber++;
            moonParts[moonNumber].SetActive(true);
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
