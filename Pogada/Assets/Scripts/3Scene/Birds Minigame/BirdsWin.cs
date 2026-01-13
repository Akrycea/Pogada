using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class BirdsWin : MonoBehaviour
{
    public int birdsWin;

    public DialogueRunner dialogueRunner;

    public GameObject BlueprintUI;

    private bool dialoguePlayed = false;   

    // Update is called once per frame
    void Update()
    {
        if (birdsWin == 5 && Input.GetMouseButton(0) == false && dialoguePlayed == false)
        {  
            Debug.Log("birds won");
            dialogueRunner.StartDialogue("D3_PtakiWygrana");
            dialoguePlayed = true;
        }
    }

    [YarnCommand("ShowBlueprintsOnUI")]
    public void BlueprintsUI()
    {
       BlueprintUI.SetActive(true);
    }
}
