using UnityEngine;
using UnityEngine.XR;
using Yarn.Unity;

public class CollectingOwl : MonoBehaviour
{
    [SerializeField]
    private StateManager stateManager;
    [SerializeField]
    private OwlChangingSprite Owl;
    [SerializeField]
    private GameObject owlMinigame;

    [SerializeField]
    private DebataPlayer debataPlayer;

    //public ClickDialogue dialogue;

    void Start()
    {

    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        stateManager.OwlCollected = true;
        owlMinigame.SetActive(true);
        debataPlayer.wygranaMinigierka = true;
        debataPlayer.sentenceBuilding();
        Owl.TurnUIon();
        //dialogue.nazwaDialogu = 
        //ukladanie zdan ^
    }
}

