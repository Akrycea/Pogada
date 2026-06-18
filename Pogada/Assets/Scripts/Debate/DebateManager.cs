using UnityEngine;
using System.Collections;

public class DebateManager : MonoBehaviour
{

    [SerializeField]
    private GameObject pogadanka;

    [SerializeField]
    private GameObject debate;

    public void OnMouseDown()
    {
        StartDebate();
    }

    public void StartDebate()
    {
        debate.SetActive(true);
        StartCoroutine(ShowPogadanka());
    }

    private IEnumerator ShowPogadanka()
    {
        pogadanka.SetActive(true);
        yield return new WaitForSeconds(3f);
        pogadanka.SetActive(false);
    }

    public void EndDebate()
    {
        debate.SetActive(false);
    }
}
