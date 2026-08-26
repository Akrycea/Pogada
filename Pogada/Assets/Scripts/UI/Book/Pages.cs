using UnityEngine;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
    [SerializeField] public Sprite[] pagesSprites;
    private int currentPageIndex = -1;
    [SerializeField] private Image pageImage;


    private void Start()
    {
        //pageImage.sprite = GetComponent<Image>().sprite;
    }

    public void UpdatePage()
    {
        currentPageIndex++;
        pageImage.sprite = pagesSprites[currentPageIndex];
    }
}
