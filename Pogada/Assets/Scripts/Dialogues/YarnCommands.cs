using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using Yarn;
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


    //nastepne klikniecie  na fiolet powinno odpalic budowanie zdan debata
    public FioletDebataPlayer fioletDebataPlayer;
    [YarnCommand("fioletBudowanieZdan")]
    public void fioletBudowanieZdan()
    {
        //fioletdebata = GameObject.Find("Fiolet").GetComponent<DebataPlayer>();
        //fioletdebata.wygranaMinigierka = true;

        fioletDebataPlayer.fioletSentenceBuilding();
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty fioletowego
    [YarnCommand("fioletDebata")]
    public void fioletDebata()
    {
        Debug.Log("odpalam debate");
        debateManager.ShowDebate();

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
        debateManager.ShowDebate();
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
        czerwonydebata.SentenceBuildingStart();
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("czerwonyDebata")]
    public void czerwonyDebata()
    {
        Debug.Log("odpalam debate");
        debateManager.ShowDebate();


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
        debateManager.ShowDebate();


    }

    public GameObject GranatDrzwi;

    //triggeruje powrót kolorów po wygranej debacie granat
    [YarnCommand("granatwygranadebata")]
    public void granatwygranadebata()
    {
        GranatDrzwi.SetActive(false);
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
        debateManager.ShowDebate();
    }


    //odpalenie minigierki ukladania zdan blekit WIP
    private DebataPlayer blekitdebata;
    [YarnCommand("blekitDebata")]
    public void blekitDebata()
    {
        blekitdebata = GameObject.Find("B³êkit").GetComponent<DebataPlayer>();
        blekitdebata.wygranaMinigierka = true;
        blekitdebata.SentenceBuildingStart();
    }

    //odpala debate z wybieraniem zdan po dobrym ulozeniu zdania podczas debaty czerwonego
    [YarnCommand("blekit2debata")]
    public void blekit2debata()
    {
        Debug.Log("odpalam debate");
        debateManager.ShowDebate();
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
        debateManager.ShowDebate();
    }

    [SerializeField] private GameObject przepis;

    [YarnCommand("fioletDwaWygranadebata")]
    public void fioletDwaWygranadebata()
    {
        przepis.SetActive(true);
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
        debateManager.ShowDebate();
    }

    [YarnCommand("zolcwygranadebata")]
    public void zolcwygranadebata()
    {
        dialRunner.StartDialogue("D13_Koniec");
    }

    [YarnCommand("Koniec")]
    public void Koniec()
    {
        Debug.Log("KONIEC");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    //stops and closes the dialogue
    private float waitTime;
    [YarnCommand("Stop")]
    public void StopDialogue(float time)
    {
        waitTime = time;
        StartCoroutine(waitStop());
    }
    IEnumerator waitStop()
    {
        yield return new WaitForSeconds(waitTime);
        dialRunner.Stop();
    }
}
