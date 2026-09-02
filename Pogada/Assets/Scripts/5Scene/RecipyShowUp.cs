using UnityEngine;
using Yarn.Unity;

public class RecipyShowUp : MonoBehaviour
{

    [SerializeField] private GameObject recipe;

    public DialogueRunner dialogueRunner;

    [SerializeField] private GameObject hintObject;


    public void OnMouseDown()
    {
        dialogueRunner.StartDialogue("P8_Potka");
        hintObject.SetActive(true);
        gameObject.SetActive(false);
        recipe.SetActive(true);
    }
}

