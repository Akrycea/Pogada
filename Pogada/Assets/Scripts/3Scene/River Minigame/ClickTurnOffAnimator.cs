using UnityEngine;
using System.Collections;

public class ClickTurnOffAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void OnMouseDown()
    {
        if (animator != null)
        {
            StartCoroutine(WaitObst());

            //if (gameObject.name == "lodka")
            //{
            //    animator.enabled = false;
            //}
            //else
            //{
            //    StartCoroutine(WaitObst());
            //}
        }
    }

    public void TurnOnAnimator()
    {
        if (animator != null)
        {
            animator.enabled = true;
        }
    }

    IEnumerator WaitObst()
    {
        animator.Play("StopState");
        yield return new WaitForSeconds(5f);
        animator.Play("MoveState");
    }
}
