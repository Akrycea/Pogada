using UnityEngine;
using Yarn.Unity;

public class FioletZolcArguing : MonoBehaviour
{
    public DialogueRunner dialogueRunner;


    public void OnMouseDown()
    {
        dialogueRunner.StartDialogue("D2_PoznanieFiolet");
        gameObject.SetActive(false);
    }
}
