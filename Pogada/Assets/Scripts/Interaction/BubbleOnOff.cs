using UnityEngine;

public class BubbleOnOff : MonoBehaviour
{

    [SerializeField] private string character;
    private InteractionAnimation kidAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        kidAnim = GameObject.Find(character).GetComponent<InteractionAnimation>();

        if (kidAnim.wantsToTalk != true)
        {
            kidAnim.wantsToTalk = true;
        }
        else
        {
            kidAnim.wantsToTalk = false;
        }
        gameObject.SetActive(false);
    }
}
