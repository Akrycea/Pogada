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

    public bool pogadankaShowed = false;

    [SerializeField] private DecorationsScript DecorationsScript;

    public void OnMouseDown()
    {
        //StartDebate();
    }

    public void StartDebate()
    {
        //if (!pogadankaShowed)
        //{
            StartCoroutine(ShowPogadanka());
            //GenUI.SetActive(false);
        //}
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
            DecorationsScript.ShowDecorations(0);
        }
        else if (debateScript.debateNumber == 1)
        {
            debateDial.StartDialogue("M15_PomocZieleni");
            DecorationsScript.ShowDecorations(1);
        }
        else if (debateScript.debateNumber == 2)
        {
            debateDial.StartDialogue("M2_PoznanieCzerwieni");
            DecorationsScript.ShowDecorations(2);
        }
        else if (debateScript.debateNumber == 3)
        {
            debateDial.StartDialogue("M3_PogodzenieGranat");
            DecorationsScript.ShowDecorations(3);
        }
        else if (debateScript.debateNumber == 4)
        {
            debateDial.StartDialogue("M31_PogodzeniePomarancz");
            DecorationsScript.ShowDecorations(4);
        }
        else if (debateScript.debateNumber == 5)
        {
            debateDial.StartDialogue("M32_PogodzenieBlekit");
            DecorationsScript.ShowDecorations(5);
        }
        else if (debateScript.debateNumber == 6)
        {
            debateDial.StartDialogue("M4_PrzekonanieFiolet");
            DecorationsScript.ShowDecorations(6);
        }
        else if (debateScript.debateNumber == 7)
        {
            debateDial.StartDialogue("M5_PogodzenieDzieci");
            DecorationsScript.ShowDecorations(7);
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
