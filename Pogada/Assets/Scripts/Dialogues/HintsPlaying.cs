using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class HintsPlaying : MonoBehaviour
{
    [SerializeField] private float hintTimer;
    public string nextHint;
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private bool readyToSayHint = false;
    public bool countingDown = false;
    [SerializeField] private Outline outline;

    private InteractionAnimation anim;
    void Start()
    {
        anim = GetComponent<InteractionAnimation>();
    }

    
    void Update()
    {
        if (countingDown && !readyToSayHint)
        {
            StartingHint();
        }

        if (readyToSayHint)
        {
            anim.wantsToTalk = true;
        }
        else
        {
            anim.wantsToTalk = false;
        }
    }

    public void StartingHint()
    {
        StartCoroutine(hintPlayer());
    }

    IEnumerator hintPlayer()
    {
        readyToSayHint = false;
        yield return new WaitForSeconds(hintTimer);
        readyToSayHint = true;
    }

    public void OnMouseDown()
    {
        if (readyToSayHint)
        {
            dialogueRunner.StartDialogue(nextHint);
            anim.hideTalkBubble();
            readyToSayHint = false;
        }
    }


    //sets bohater's next hint
    [YarnCommand("changeHint")]
    public void changeHint(string hint)
    {
        gameObject.GetComponent<HintsPlaying>().nextHint = hint;
    }

    //clears hints
    [YarnCommand("clearHint")]
    public void clearHint(string hint)
    {
        countingDown = false;
        gameObject.GetComponent<HintsPlaying>().nextHint = "";
    }
}
