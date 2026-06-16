using UnityEngine;
using Yarn.Unity;

public class IconTurnOn : MonoBehaviour
{
    [SerializeField]
    private GameObject Icons;
   [YarnCommand("IconsOn")]
   public void TurnIconsOn()
    {
        Icons.SetActive(true);
    }

    [YarnCommand("IconsOff")]
    public void TurnIconsOff()
    {
        Icons.SetActive(false);
    }

    [SerializeField]
    private GameObject IconPlayer;
    [YarnCommand("IconPlayerOn")]
    public void TurnIconPlayerOn()
    {
        IconPlayer.SetActive(true);
    }

    [YarnCommand("IconPlayerOff")]
    public void TurnIconPlayerOff()
    {
        IconPlayer.SetActive(false);
    }
}
