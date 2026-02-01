using UnityEngine;

public class CollectingOwl : MonoBehaviour
{

    //public FishWon fishWon;

    public GameObject OwlOnUI;
    public GameObject Colliders;

    private void OnMouseDown()
    {
        //fishWon.allFish += 1;
        gameObject.SetActive(false);
        OwlOnUI.SetActive(true);
        Colliders.SetActive(true);
    }
}
