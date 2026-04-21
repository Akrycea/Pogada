using UnityEngine;
using UnityEngine.XR;

public class CollectingOwl : MonoBehaviour
{

    //public FishWon fishWon;

    public GameObject OwlOnUI;
    public GameObject Colliders;

    private StateManager stateManager;

    void Start()
    {
        //Colliders = GameObject.Find("Hand");
        stateManager = GameObject.Find("PuzzleManager").GetComponent<StateManager>();
        OwlOnUI = GameObject.Find("OwlOnUI");
    }

    private void OnMouseDown()
    {
        //fishWon.allFish += 1;
        gameObject.SetActive(false);
        stateManager.OwlCollected = true;
        OwlOnUI.SetActive(true);
        //Colliders.SetActive(true);
    }
}
