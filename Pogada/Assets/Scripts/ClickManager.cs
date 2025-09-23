using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ClickManager : MonoBehaviour
{
    public bool canClickBG;

    //zbieralne i interaktowalne
    public InterakcjeZbieranie puzzleManager;



    void Start()
    {
        canClickBG = true;
    }

    void Update()
    {
        whatGetsClicked();
    }


    //wyczuwa co zostalo klikniete i mowi co zrobic w zwiazku z tym
    void whatGetsClicked()
    {

        if (Input.GetMouseButtonDown(0) && canClickBG)
        {

            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

            //sprawdza wszystkie przedmioty z tagiem ZBIERALNE
            if (rayHit.transform.CompareTag("ZBIERALNE"))
            {
                //co robi klikniecie na dany przedmiot
                if (rayHit.transform.name == "Klucz")
                {
                    Debug.Log("Klikniêto na " + rayHit.transform.name);
                    //tutaj wywolujemy ze zebrany przedmiot
                    puzzleManager.KeyTaken();
                }
            }

            //sprawdza wszystkie przemdioty z tagiem INTERAKTOWALNE
            else if (rayHit.transform.CompareTag("INTERAKTOWALNE"))
            {
                if (rayHit.transform.name == "Wrota")
                {
                    Debug.Log("Klikniêto na " + rayHit.transform.name);
                    //tutaj wywolujemy metode po kliknieciu przedmiotu
                    puzzleManager.DoorOpen();
                }
                else if (rayHit.transform.name == "Minigra1")
                {
                    Debug.Log("Klikniêto na " + rayHit.transform.name);
                    //tutaj wywolujemy metode po kliknieciu przedmiotu
                    puzzleManager.OpenMinigame1();
                }
            }

        }

    }


}
