using UnityEngine;
using Yarn.Unity;

public class DebataPlayer : MonoBehaviour
{
    public StateManager stateManager;
    public bool wygranaMinigierka;

    public GameObject budowanieZdan1;
    public GameObject budowanieZdan2;
    public GameObject budowanieZdan3;

    public bool debateWon;

    public int playedDebates = 0;

    public void OnMouseDown()
    {
        if (wygranaMinigierka && playedDebates ==  0  && !debateWon)
        {
            budowanieZdan1.SetActive(true);
            playedDebates++;
        }
        else if (wygranaMinigierka && playedDebates == 1 && !debateWon)
        {
            budowanieZdan2.SetActive(true);
            playedDebates++;
        }
        else if (wygranaMinigierka && playedDebates >= 2 && !debateWon)
        {
            budowanieZdan3.SetActive(true);
            playedDebates++;
        }
    }

    [YarnCommand("debateWon")]
    public void SettingDebateWon()
    {
        debateWon = true;
    }
}
