using UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public DialogueRunner dialRunner;

    public ColorChange colorChange;

    //po rozmowie z zielonym pozwala pogadac z granat
    private ClickDialogue granat;
    [YarnCommand("granatOdpalDialog")]
    public void granatOdpalaDialog()
    {
        granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
        granat.nazwaDialogu = "D4_PoznanieGranat";
    }
    //zmienia dialog zielonego po kliknieciu na drugi
    private ClickDialogue zielony;
    [YarnCommand("zielony2dialog")]
    public void zielony2dialog()
    {
        zielony = GameObject.Find("Zielony").GetComponent<ClickDialogue>();
        zielony.nazwaDialogu = "D5_PomocZieleni";
        zielony.dialoguePlayed = false;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania
    [YarnCommand("zielony2debata")]
    public void zielony2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M15_PomocZieleni");
    }

    [YarnCommand("zielonywygranadebata")]
    public void zielonywygranadebata()
    {
        colorChange.szary = false;
        colorChange.zielony = true;
    }
}
