using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class HintsPlaying : MonoBehaviour
{
    public float hintTimer;
    public string nextHint;
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private bool readyToSayHint = false;
    public bool playingHints = false;
    public bool countingDown = false;
    [SerializeField] private Outline outline;

    private InteractionAnimation anim;
    void Start()
    {
        anim = GetComponent<InteractionAnimation>();
    }

    
    void Update()
    {
        if (playingHints)
        {
            if (countingDown && !readyToSayHint)
            {
                StartingHint();
            }
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
        countingDown = false;
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
            countingDown = true;
            readyToSayHint = false;
        }
    }


    //sets bohater's next hint
    [YarnCommand("changeHint")]
    public void changeHint(string hint)
    {
        gameObject.GetComponent<HintsPlaying>().nextHint = hint;
    }

    //sets bohater's next hint timer
    [YarnCommand("changeHintTime")]
    public void changeHintTime(float time)
    {
        gameObject.GetComponent<HintsPlaying>().hintTimer = time;
    }

    //clears hints
    [YarnCommand("clearHint")]
    public void clearHint()
    {
        playingHints = false;
        readyToSayHint = false;
        countingDown = false;
        gameObject.GetComponent<HintsPlaying>().nextHint = "";
    }
}
