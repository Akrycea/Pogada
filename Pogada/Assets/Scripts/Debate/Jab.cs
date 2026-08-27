using UnityEngine;
using Yarn.Unity;
using System.Collections;

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

        StartCoroutine(JabTimer());
    }
    private IEnumerator JabTimer()
    {
        yield return new WaitForSeconds(5f);

        if(jabOBJ.activeSelf)
        {
            pointer.JabFail();
            jabOBJ.SetActive(false);
            Debug.Log("Jab ended after 5 seconds.");
        }
    }
}
