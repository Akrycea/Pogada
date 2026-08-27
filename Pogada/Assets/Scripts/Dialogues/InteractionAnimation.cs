using System.Collections;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class InteractionAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public bool wantsToTalk;
    [SerializeField] private Vector3 displacement;
    void Start()
    {

    }

    void Update()
    {
        if (wantsToTalk)
        {
            animator.Play("WantsTalk");
        }
    }



    [YarnCommand ("showTalkBubble")]
    public void showTalkBubble()
    {
        wantsToTalk = true;
    }

    [YarnCommand("hideTalkBubble")]
    public void hideTalkBubble()
    {
        Debug.Log("stopping bubble");
        wantsToTalk = false;
        StartCoroutine(waitToPopBubble());
    }
    IEnumerator waitToPopBubble()
    {
        animator.Play("InteractedWith");
        yield return new WaitForSeconds(2);
        animator.Play("None");
    }

    [YarnCommand("runAwayAnim")]
    public void runAwayAnim()
    {
        StartCoroutine(playRunAway());
    }

    IEnumerator playRunAway()
    {
        gameObject.transform.position = GetComponentInParent<Transform>().position - displacement;
        animator.Play("RunAway");
        yield return new WaitForSeconds(1);
        animator.Play("None");
        gameObject.transform.position = GetComponentInParent<Transform>().position + displacement;
    }
}
