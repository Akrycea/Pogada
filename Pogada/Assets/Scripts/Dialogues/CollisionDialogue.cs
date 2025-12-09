using UnityEngine;
using Yarn.Unity;

public class CollisionDialogue : MonoBehaviour
{
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    //bool mozna zmienic na public i wykorzystac w  innym skrypcie np. po odpaleniu tego dialogu mozna cos zrobic
    public bool dialoguePlayed = false;

    public void OnTriggerEnter2D(Collider other)
    {
        if (!dialoguePlayed && other.name == "Player")
        {
            dialogueRunner.StartDialogue(nazwaDialogu);
            dialoguePlayed = true;
        }
    }
}
