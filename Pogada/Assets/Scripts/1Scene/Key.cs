using UnityEngine;
using Yarn.Unity;

public class Key : MonoBehaviour
{

    public DialogueRunner dialogueRunner;

    public Doormat doormat;
    public SpriteChangeAfterPuzzle gateSpriteChange;

    public GameObject gateStop;

 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "gateCollider" && doormat.openDoormat == true)
        {
            gateSpriteChange.myPuzzleGotCompleted();
            gateStop.gameObject.SetActive(false);
            dialogueRunner.StartDialogue("P1_Brama_fin");
        }

    }
}
