using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class BookBehavior : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPages;
    [SerializeField] private GameObject[] allPages;
    [SerializeField] private int currentPageIndex = 0;
    [SerializeField] private int totalPages = 0;

    [SerializeField] private Pages[] pagesScripts;

    [SerializeField] private GameObject Journal;
    [SerializeField] private GameObject JournalButton;

    [SerializeField] private TurnOffCollider turnOffCollider;
    [SerializeField] private GameObject UI;

    void Start()
    {
        totalPages = playerPages.Length;
    }

    [YarnCommand("OpenBook")]
    public void OpenBook()
    {
        Journal.SetActive(true);
        JournalButton.SetActive(false);

        turnOffCollider.DisableAllExceptSpecificTag();
        UI.SetActive(false);
    }

    public void CloseBook()
    {
        Journal.SetActive(false);
        JournalButton.SetActive(true);

        turnOffCollider.EnableAllColliders();
        UI.SetActive(true);
    }


    public void LeftPage()
    {
        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex--;

        if (currentPageIndex < 0)
        {
            currentPageIndex = totalPages - 1; // Wrap around to the last page
        }

        playerPages[currentPageIndex].SetActive(true);
    }

    public void RightPage()
    {
        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex++;

        if (currentPageIndex >= totalPages)
        {
            currentPageIndex = 0; // Wrap around to the first page     
        }

        playerPages[currentPageIndex].SetActive(true);
    }

    [YarnCommand("NewPage")]
    public void NewPage(int index)
    {
        System.Array.Resize(ref playerPages, index);
        playerPages[index - 1] = allPages[index - 1];

        totalPages = playerPages.Length;

        //dodaj ze pokazuje na ta strone jak doda nowa
        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex = totalPages - 1;
        playerPages[currentPageIndex].SetActive(true);
    }

    [YarnCommand("UpdatePage")]
    public void UpdatePage(int index)
    {
        pagesScripts[index - 1].UpdatePage();

        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex = index - 1;
        playerPages[currentPageIndex].SetActive(true);
    }
}
