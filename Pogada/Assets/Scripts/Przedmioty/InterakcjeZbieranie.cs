using UnityEngine;

public class InterakcjeZbieranie : MonoBehaviour
{
    public ClickManager clickManager;

    private void Start()
    {
        OknoMinigry.SetActive(false);
    }

    //zagadka 1
    public GameObject Klucz;
    public bool keyTaken = false;
    public void KeyTaken()
    {
        keyTaken = true;
        Klucz.SetActive(false);
        Debug.Log("Zebrano Klucz");
    }
    public void DoorOpen()
    {
        if (keyTaken)
        {
            Debug.Log("Otwarto Wrota");
        }
        else
        {
            Debug.Log("Brak Klucza");
        }
    }


    //minigra 1
    public GameObject OknoMinigry;
    public void OpenMinigame1()
    {
        //tutaj mozna dodac if zeby dalo sie otworzyc dopiero w danym momencie
        clickManager.canClickBG = false;
        OknoMinigry.SetActive(true);
    }
}
