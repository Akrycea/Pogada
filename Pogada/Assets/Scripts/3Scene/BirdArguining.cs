using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class BirdArguining : MonoBehaviour
{
    public GameObject birdOnUI;
    public DialogueRunner dialogueRunner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(birdOnUI.activeSelf)
        {
            //here it depends how the dialoue will go but in the end will
            dialogueRunner.StartDialogue("D3_PtakWraca");
            gameObject.SetActive(false);
            //start minigame here in whatever way dude
        }
    }
}
