using UnityEngine;

public class DebataPlayer : MonoBehaviour
{
    public bool wygranaMinigierka;

    public GameObject budowanieZdan;

    private bool done = false;

    public void OnMouseDown()
    {
        if (wygranaMinigierka && done == false)
        {
            budowanieZdan.SetActive(true);
            done = true;
        }
    }
}
