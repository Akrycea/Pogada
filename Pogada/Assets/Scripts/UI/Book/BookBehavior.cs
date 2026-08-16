using UnityEngine;
using UnityEngine.UI;

public class BookBehavior : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPages;
    [SerializeField] private GameObject[] allPages;
    [SerializeField] private int currentPageIndex = 0;
    [SerializeField] private int totalPages = 0;

    [SerializeField] private Pages[] pagesScripts;

    void Start()
    {
        totalPages = playerPages.Length;
    }

    public void OpenBook()
    {
        gameObject.SetActive(true);
    }

    public void CloseBook()
    {
        gameObject.SetActive(false);
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


    public void NewPage(int index)
    {
        playerPages[index] = allPages[index];

        totalPages = playerPages.Length;

        //dodaj ze pokazuje na ta strone jak doda nowa
        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex = totalPages - 1;
        playerPages[currentPageIndex].SetActive(true);
    }

    public void UpdatePage(int index)
    {
        pagesScripts[index].UpdatePage();

        playerPages[currentPageIndex].SetActive(false);
        currentPageIndex = index;
        playerPages[currentPageIndex].SetActive(true);
    }
}
