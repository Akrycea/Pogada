using UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    //deklaracje potrzebne do 99% komend
    public DialogueRunner dialRunner;
    public ColorChange colorChange;

    //komentarze bohatera na P1_Brama
    private ClickDialogue brama;
    [YarnCommand("bramaPuzzle1")]
    public void bramaPuzzle1()
    {
        brama = GameObject.Find("gateCollider").GetComponent<ClickDialogue>();
        brama.nazwaDialogu = "P1_Brama_1";
        brama.dialoguePlayed = false;
    }
    [YarnCommand("bramaPuzzle2")]
    public void bramaPuzzle2()
    {
        brama = GameObject.Find("gateCollider").GetComponent<ClickDialogue>();
        brama.nazwaDialogu = "P1_Brama_2";
        brama.dialoguePlayed = false;
    }
    [YarnCommand("bramaPuzzle3")]
    public void bramaPuzzle3()
    {
        brama = GameObject.Find("gateCollider").GetComponent<ClickDialogue>();
        brama.nazwaDialogu = "P1_Brama_3";
        brama.dialoguePlayed = false;
    }

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

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty zielonego
    [YarnCommand("zielony2debata")]
    public void zielony2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M15_PomocZieleni");
    }

    //triggeruje powrót kolorów po wygranej debacie zielonego
    [YarnCommand("zielonywygranadebata")]
    public void zielonywygranadebata()
    {
        colorChange.szary = false;
        colorChange.zielony = true;
    }

    //odpala dialog o blueprincie z zielonym po dotknieciu collideru
    private CollisionDialogue dialtriggerBlueprints;
    [YarnCommand("playBlueprintDialGreen")]
    public void triggerPlaysBlueprintDialogue()
    {
        dialtriggerBlueprints = GameObject.Find("DialTriggerBlueprint").GetComponent<CollisionDialogue>();
        dialtriggerBlueprints.nazwaDialogu = "D6_ZnalezcCzerwien";
    }

    //tutaj daj odpalenie minigierki ukladania zdan czerwonego

    //triggeruje powrót kolorów po wygranej debacie zielonego
    [YarnCommand("czerwonywygranadebata")]
    public void czerwonywygranadebata()
    {
        colorChange.zielony = false;
        colorChange.czerwony = true;
    }
}
