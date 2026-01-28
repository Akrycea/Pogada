using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class BirdArguining : MonoBehaviour
{
    public GameObject birdOnUI;
    public GameObject minigame;
    public GameObject Debata;

    public DialogueRunner dialogueRunner;


    public void OnMouseDown()
    {
        if(birdOnUI.activeInHierarchy == true && Debata.activeInHierarchy == false)
        {
            dialogueRunner.StartDialogue("D3_PtakWraca");
        }
        else
        {
            dialogueRunner.StartDialogue("D3_PtakiKlocaceSie");
        }
    }

    [YarnCommand("BirdsArguining")]
    public void BirdsArguning()
    {
        birdOnUI.SetActive(false);
        gameObject.SetActive(false);
        minigame.SetActive(true);
    }
}

