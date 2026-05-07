using UnityEngine;
using Yarn.Unity;

public class Jab : MonoBehaviour
{
    public GameObject jabOBJ;

    public JabbingInBG jabbingInBG;
    public Pointer pointer;

    [YarnCommand("Jab")]
    public void Jabbing(string good, string bad)
    {
        jabOBJ.SetActive(true);
        jabbingInBG.JabbingInZone();

        pointer.good = good;
        pointer.bad = bad;

        Debug.Log("Jab command executed with good: " + good + " and bad: " + bad);
    }
}
