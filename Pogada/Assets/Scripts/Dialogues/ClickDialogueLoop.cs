using UnityEngine;
using Yarn.Unity;

public class ClickDialogueLoop : MonoBehaviour
{
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

  
    public void OnMouseDown()
    {
         dialogueRunner.StartDialogue(nazwaDialogu);
    }
}
