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
        if (countingDown)
        {
            StartingHint();
        }

        if (readyToSayHint)
        {
            anim.wantsToTalk = true;
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
            readyToSayHint =false;
        }
    }


    //sets bohater's next hint
    [YarnCommand("changeHint")]
    public void changeHint(string hint)
    {
        gameObject.GetComponent<HintsPlaying>().nextHint = hint;
    }

    private void OnMouseOver()
    {
        outline.interactable = true;
    }
}
