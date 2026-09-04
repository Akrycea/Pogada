using UnityEngine;
using Yarn.Unity;
using UnityEngine.UIElements;
using System.Collections;

public class DebataPlayer : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;
    public StateManager stateManager;
    public bool wygranaMinigierka;

    public GameObject budowanieZdan1;
    public GameObject budowanieZdan2;
    public GameObject budowanieZdan3;

    [SerializeField] private GameObject UI1;
    [SerializeField] private GameObject UI2;
    [SerializeField] private GameObject UI3;

    public bool debateWon;

    public int playedDebates = 0;

    [SerializeField]
    public TurnOffCollider turnOffCollider;

    public DebateManager debateManager;

    [SerializeField] private bool pogadankaShowed = false;

    public void OnMouseDown()
    {
        if (wygranaMinigierka)
        {
            //debateManager.StartDebate();
            ////sentenceBuilding();
            //StartCoroutine(WaitForPogadanka());

            SentenceBuildingStart();
        }
    }

    public void SentenceBuildingStart()
    {
        debateManager.StartDebate();
        StartCoroutine(WaitForPogadanka());
    }

    private IEnumerator WaitForPogadanka()
    {
        yield return new WaitForSeconds(3f);
        sentenceBuilding();
    }

    public void sentenceBuilding()
    {
        if (wygranaMinigierka && playedDebates == 0 && !debateWon)
        {
            turnOffCollider.DisableAllExceptSpecificTag();
            Debug.Log("starting sentence building");
            budowanieZdan1.SetActive(true);
            UI1.SetActive(true);
            Debug.Log("blocking player movement");
            playerMovement.canPlayerMove = false;
            playedDebates++;
        }
        else if (wygranaMinigierka && playedDebates == 1 && !debateWon)
        {
            budowanieZdan2.SetActive(true);
            UI2.SetActive(true);
            playedDebates++;
        }
        else if (wygranaMinigierka && playedDebates >= 2 && !debateWon)
        {
            budowanieZdan3.SetActive(true);
            UI3.SetActive(true);
            playedDebates++;
        }
    }

    [YarnCommand("debateWon")]
    public void SettingDebateWon()
    {
        debateWon = true;
        pogadankaShowed = false;
    }
}
