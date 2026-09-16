using System.Collections;
using UnityEngine;

public class KidMoveToTree : MonoBehaviour
{
    [SerializeField] private int afterThisDebate;
    [SerializeField] private float waitTime;
    [SerializeField] private KidRunAway runAway;
    private InteractionAnimation anim;
    [SerializeField] private Debate debate;
    void Start()
    {
        anim = GetComponent<InteractionAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (afterThisDebate <= debate.debateNumber)
        {
            StartCoroutine(goingToTree());
        }
    }

    IEnumerator goingToTree()
    {
        yield return new WaitForSeconds(waitTime);
        anim.runAwayAnim();
        yield return new WaitForSeconds(0.5f);
        runAway.kidRunAway();
        gameObject.GetComponent<KidMoveToTree>().enabled = false;
    }
}
