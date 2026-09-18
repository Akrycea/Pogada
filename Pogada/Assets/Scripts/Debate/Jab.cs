using UnityEngine;
using Yarn.Unity;
using System.Collections;

public class Jab : MonoBehaviour
{
    [SerializeField] private GameObject[] jabOBJs;

    [SerializeField] JabbingInBG[] jabbingInBG;
    [SerializeField] Pointer[] pointer;

    [SerializeField] private int JabNumber;

    [SerializeField] private bool isJabbing;

    [YarnCommand("Jab")]
    public void Jabbing(string good, string bad, int number)
    {
        jabOBJs[number].SetActive(true);
        jabbingInBG[number].JabbingInZone();

        pointer[number].good = good;
        pointer[number].bad = bad;

        Debug.Log("Jab command executed with good: " + good + " and bad: " + bad);

        JabNumber = number;
        //StartCoroutine(JabTimer());
        
    }
    private IEnumerator JabTimer()
    {
        yield return new WaitForSeconds(10f);

        if (jabOBJs[JabNumber].activeSelf)
        {
            pointer[JabNumber].JabFail();
            jabOBJs[JabNumber].SetActive(false);
            Debug.Log("Jab ended after 10 seconds.");
        }
    }
}
