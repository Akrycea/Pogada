using UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    //deklaracje potrzebne do 99% komend
    public DialogueRunner dialRunner;
    public StateManager stateManager;

    public DialogueRunner debateDial;

    public DebateManager debateManager;

    [SerializeField]
    private PlayerMovement playerMovement;
    //blokuje gracza podczas dialogu
    [YarnCommand("blockPlayerMovement")]
    public void blockPlayerMovement()
    {
        Debug.Log("blocking player movement");
        playerMovement.canPlayerMove = false;
    }

    //odblokowuje gracza podczas dialogu
    [YarnCommand("unblockPlayerMovement")]
    public void unblockPlayerMovement()
    {
        Debug.Log("UNblocking player movement");
        playerMovement.canPlayerMove = true;
    }

    //sets character's next dialogue
    [YarnCommand("changeCharacterDialogue")]
    public void changeCharDialogue(string character, string dialogue)
    {
        GameObject.Find(character).GetComponent<ClickDialogue>().nazwaDialogu = dialogue;
    }

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

    //nastepne klikniecie  na fiolet powinno odpalic budowanie zdan debata
    private DebataPlayer fioletdebata;
    [YarnCommand("fioletBudowanieZdan")]
    public void fioletBudowanieZdan()
    {
        fioletdebata = GameObject.Find("Fiolet").GetComponent<DebataPlayer>();
        fioletdebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty fioletowego
    [YarnCommand("fioletDebata")]
    public void fioletDebata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M1_PoznanieFiolet");
        
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
        debateManager.StartDebate();
    }

    //triggeruje powrót kolorów po wygranej debacie zielonego
    [YarnCommand("zielonywygranadebata")]
    public void zielonywygranadebata()
    {
        granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
        granat.nazwaDialogu = "D8_PrzekonanieCzerwieni";
    }

    //odpala dialog o blueprincie z zielonym po dotknieciu collideru
    private CollisionDialogue dialtriggerBlueprints;
    
    [YarnCommand("playBlueprintDialGreen")]
    public void triggerPlaysBlueprintDialogue()
    {
        dialtriggerBlueprints = GameObject.Find("DialTriggerBlueprint").GetComponent<CollisionDialogue>();
        dialtriggerBlueprints.nazwaDialogu = "D6_ZnalezcCzerwien";
    }

    public GameObject Blueprints;
    //pokazanie blueprintow
    [YarnCommand("showblueprints")]
    public void showblueprints() 
    {
        Blueprints.gameObject.SetActive(true);
    }

    public GameObject Czerwony;
  
    //odpalenie minigierki ukladania zdan czerwonego
    private DebataPlayer czerwonydebata;
    [YarnCommand("czerwonyBudowanieZdan")]
    public void czerwonyBudowanieZdan()
    {
        czerwonydebata = GameObject.Find("Czerwony").GetComponent<DebataPlayer>();
        czerwonydebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("czerwonyDebata")]
    public void czerwonyDebata()
    {
        Debug.Log("odpalam debate");
        debateManager.StartDebate();
       
        
    }

    //po debacie z czerwonym pozwala pogadac z granat i zaczac jej quest
    [YarnCommand("granatOdpalQuest")]
    public void granatOdpalaQuest()
    {
        granat = GameObject.Find("Granat").GetComponent<ClickDialogue>();
        granat.nazwaDialogu = "D8_PrzekonanieCzerwieni";
        granat.dialoguePlayed = false;
    }

    //odpalenie minigierki ukladania zdan granat
    private DebataPlayer granatdebata;
    [YarnCommand("granatDebata")]
    public void granatDebata()
    {
        granatdebata = GameObject.Find("Granat").GetComponent<DebataPlayer>();
        granatdebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty granat
    [YarnCommand("granat2debata")]
    public void granat2debata()
    {
        Debug.Log("odpalam debate");
        debateManager.StartDebate();
        
        
    }

    public GameObject GranatDrzwi;

    //triggeruje powrót kolorów po wygranej debacie granat
    [YarnCommand("granatwygranadebata")]
    public void granatwygranadebata()
    {
        GranatDrzwi.SetActive(true);
    }

    //odpalenie minigierki ukladania zdan pomarancz WIP
    private DebataPlayer pomaranczdebata;
    [YarnCommand("pomaranczDebata")]
    public void pomaranczDebata()
    {
        pomaranczdebata = GameObject.Find("Pomarañcz").GetComponent<DebataPlayer>();
        pomaranczdebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("pomarnacz2debata")]
    public void pomarnacz2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M31_PogodzeniePomarancz");
    }


    //odpalenie minigierki ukladania zdan blekit WIP
    private DebataPlayer blekitdebata;
    [YarnCommand("blekitDebata")]
    public void blekitDebata()
    {
        blekitdebata = GameObject.Find("B³êkit").GetComponent<DebataPlayer>();
        blekitdebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("blekit2debata")]
    public void blekit2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M32_PogodzenieBlekit");
    }

    //triggeruje powrót kolorów po wygranej debacie czerwonego
    [YarnCommand("blekitwygranadebata")]
    public void blekitwygranadebata()
    {
        dialRunner.StartDialogue("D12_PoznanieZolci");
    }

    //odpalenie minigierki ukladania zdan fioletDwa WIP
    private DebataPlayer fioletDwadebata;
    [YarnCommand("fioletDwaDebata")]
    public void fioletDwaDebata()
    {
        fioletDwadebata = GameObject.Find("Fiolet").GetComponent<DebataPlayer>();
        fioletDwadebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("fioletDwa2debata")]
    public void fioletDwa2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M4_PrzekonanieFiolet");
    }

    //odpalenie minigierki ukladania zdan zolc WIP
    private DebataPlayer zolcdebata;
    [YarnCommand("zolcDebata")]
    public void zolcDebata()
    {
        zolcdebata = GameObject.Find("Fiolet").GetComponent<DebataPlayer>();
        zolcdebata.wygranaMinigierka = true;
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("zolc2debata")]
    public void zolc2debata()
    {
        Debug.Log("odpalam debate");
        dialRunner.StartDialogue("M5_PogodzenieDzieci");
    }



    //odslania liscie i zagadke z rzeczka
    [YarnCommand("odslonliscie")]
    public void odlosnliscie()
    {
        GameObject.Find("liscie").SetActive(false);
        GameObject.Find("lodka").GetComponent<Collider2D>().enabled = true;
    }

    //usun rybki na UI
    [YarnCommand("DeleteFishUI")]
    public void UsunRybyUI()
    {
        GameObject.Find("FishOnUI").SetActive(false);
    }
}
