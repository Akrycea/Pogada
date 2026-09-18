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

    [SerializeField] private PlayerMovement playerMovement;

    [SerializeField] private TurnOffCollider turnOffCollider;
    [SerializeField] private GameObject UI;

    [SerializeField] private bool wasUIon;

    //NA EXPO TYLKO IDK HOW TO DO IT BETTER
    [SerializeField] private Collider2D CheckCollider;
    [SerializeField] private bool wereCollidersOn;

    void Start()
    {
        totalPages = playerPages.Length;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Journal.activeSelf)
        {
            CloseBook();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Journal.activeSelf)
        {
            LeftPage();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && Journal.activeSelf)
        {
            RightPage();
        }
    }
    

    [YarnCommand("OpenBook")]
    public void OpenBook()
    {
        Journal.SetActive(true);
        JournalButton.SetActive(false);

        if (UI.activeSelf)
        {
            wasUIon = true;
        }
        else
        {
            wasUIon = false;
        }

        if (CheckCollider.enabled == true)
        {
            wereCollidersOn = true;
        }
        else
        {
            wereCollidersOn = false;
        }

        turnOffCollider.DisableAllExceptSpecificTag();
        UI.SetActive(false);

        playerMovement.canPlayerMove = false;
    }

    public void CloseBook()
    {
        Journal.SetActive(false);
        JournalButton.SetActive(true);

        if (wasUIon)
        {
            UI.SetActive(true);
        }
        else
        {
            UI.SetActive(false);
        }

        if (wereCollidersOn)
        {
            turnOffCollider.EnableAllColliders();
        }
  
        playerMovement.canPlayerMove = true;
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
