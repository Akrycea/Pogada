using UnityEngine;
using Yarn.Unity;

public class ClickDialog : MonoBehaviour
{
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    //bool mozna zmienic na public i wykorzystac w  innym skrypcie np. po odpaleniu tego dialogu mozna cos zrobic
    public bool dialoguePlayed = false;

    public void OnMouseDown()
    {
        if (!dialoguePlayed)
        {
            dialogueRunner.StartDialogue(nazwaDialogu);
            dialoguePlayed=true;
        }
    }
}
