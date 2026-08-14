using UnityEngine;

public class ClickTurnOffAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void OnMouseDown()
    {
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    public void TurnOnAnimator()
    {
        if (animator != null)
        {
            animator.enabled = true;
        }
    }
}
