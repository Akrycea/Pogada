using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class HintsPlaying : MonoBehaviour
{
    public float hintTimer;
    public string nextHint;
    [SerializeField] private DialogueRunner dialogueRunner;
    public bool playingHints = false;
    [SerializeField] private bool readyToSayHint = false;
    public bool countingDown = false;


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
        anim.wantsToTalk = true;
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
        readyToSayHint = false;
        countingDown = false;
        playingHints = false;
        anim.hideTalkBubble();
        gameObject.GetComponent<HintsPlaying>().nextHint = "";
    }

    //start playing hints
    [YarnCommand("startHint")]
    public void startHint(string hint)
    {
        gameObject.GetComponent<HintsPlaying>().nextHint = hint;
        readyToSayHint = false;
        countingDown = true;
        playingHints = true;
    }
}
