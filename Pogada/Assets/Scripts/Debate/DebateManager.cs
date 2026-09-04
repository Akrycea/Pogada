using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;   
using Yarn.Unity;

public class DebateManager : MonoBehaviour
{

    [SerializeField]
    private GameObject pogadanka;

    [SerializeField]
    private GameObject debate;

    [SerializeField]
    private GameObject dialogue;

    public Debate debateScript;

    public DialogueRunner debateDial;

    [SerializeField]
    public TurnOffCollider turnOffCollider;

    public DebataPlayer sentenceBuilding;

    [SerializeField] private GameObject Dialogi;
    [SerializeField] private GameObject GenUI;

    private bool pogadankaShowed = false;

    public void OnMouseDown()
    {
        //StartDebate();
    }

    public void StartDebate()
    {
        if(!pogadankaShowed)
        {
            StartCoroutine(ShowPogadanka());
            GenUI.SetActive(false);
        }    
    }

    private IEnumerator ShowPogadanka()
    {
        pogadanka.SetActive(true);
        yield return new WaitForSeconds(3f);
        pogadanka.SetActive(false);
    }

    public void ShowDebate()
    {
        debate.SetActive(true);
        dialogue.SetActive(false);

        if (debateScript.debateNumber == 0)
        {
            debateDial.StartDialogue("M1_PoznanieFiolet");
        }
        else if (debateScript.debateNumber == 1)
        {
            debateDial.StartDialogue("M15_PomocZieleni");
        }
        else if (debateScript.debateNumber == 2)
        {
            debateDial.StartDialogue("M2_PoznanieCzerwieni");
        }
        else if (debateScript.debateNumber == 3)
        {
            debateDial.StartDialogue("M3_PogodzenieGranat");
        }
        else if (debateScript.debateNumber == 4)
        {
            debateDial.StartDialogue("M31_PogodzeniePomarancz");
        }
        else if (debateScript.debateNumber == 5)
        {
            debateDial.StartDialogue("M32_PogodzenieBlekit");
        }
        else if (debateScript.debateNumber == 6)
        {
            debateDial.StartDialogue("M4_PrzekonanieFiolet");
        }
        else if (debateScript.debateNumber == 7)
        {
            debateDial.StartDialogue("M5_PogodzenieDzieci");
        }
    }

    public void EndDebate()
    {
        debate.SetActive(false);
        dialogue.SetActive(true);
        Dialogi.SetActive(true);
        GenUI.SetActive(true);
    }
}
