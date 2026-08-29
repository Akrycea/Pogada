using UnityEngine;
using Yarn.Unity;

public class TurnOffUI : MonoBehaviour
{
    [SerializeField] private GameObject UI;

    [YarnCommand("UIon")]
    public void UIon()
    {
        UI.SetActive(true);
    }

    [YarnCommand ("UIoff")]
    public void UIoff()
    {
        UI.SetActive (false);
    }
}
