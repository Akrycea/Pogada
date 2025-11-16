using UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    //zmienia dialog zielonego po kliknieciu na drugi
    private ClickDialog zielony;
    [YarnCommand("zielony2dialog")]
    public void green2voice()
    {
        zielony = GameObject.Find("Zielony").GetComponent<ClickDialog>();
        zielony.nazwaDialogu = "D5_PomocZieleni";
        zielony.dialoguePlayed = false;
    }
}
