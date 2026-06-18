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

    public void OnMouseDown()
    {
        StartDebate();
    }

    public void StartDebate()
    {
        debate.SetActive(true);
        dialogue.SetActive(false);
        StartCoroutine(ShowPogadanka());

        
    }

    private IEnumerator ShowPogadanka()
    {
        //debateDial.StartDialogue("M15_PomocZieleni");

        pogadanka.SetActive(true);
        yield return new WaitForSeconds(3f);
        pogadanka.SetActive(false);

        if (debateScript.debateNumber == 0)
        {
            debateDial.StartDialogue("M15_PomocZieleni");
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
    }

    public void EndDebate()
    {
        debate.SetActive(false);
        dialogue.SetActive(true);
        turnOffCollider.EnableAllColliders();
    }
}
