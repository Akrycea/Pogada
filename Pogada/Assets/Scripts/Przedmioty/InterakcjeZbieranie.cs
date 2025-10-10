using UnityEngine;
using UnityEngine.SceneManagement;

public class InterakcjeZbieranie : MonoBehaviour
{
    public ClickManager clickManager;
    public ColorChange colorChange;

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
            colorChange.szary = false;
            colorChange.zielony = true;
            //zmiana sceny kiedy rozwi¹¿e sie zagadke i kliknie drzwi
            //SceneManager.LoadScene(sceneBuildIndex:1);
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
