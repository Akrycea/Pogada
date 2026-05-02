using UnityEngine;
using UnityEngine.XR;
using Yarn.Unity;

public class CollectingOwl : MonoBehaviour
{
    //public GameObject OwlOnUI;

    private StateManager stateManager;
    public OwlChangingSprite Owl;

    //public ClickDialogue dialogue;

    void Start()
    {
        //nie wiem jak inczej zrobic reference do innej sceny
        stateManager = GameObject.Find("StateManager").GetComponent<StateManager>();
        Owl = GameObject.Find("Player").GetComponent<OwlChangingSprite>();
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        stateManager.OwlCollected = true;
        Owl.TurnUIon();
        //dialogue.nazwaDialogu = 
        //ukladanie zdan ^
    }
}

