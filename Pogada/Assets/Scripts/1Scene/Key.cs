using UnityEngine;
using Yarn.Unity;

public class Key : MonoBehaviour
{

    public DialogueRunner dialogueRunner;

    public Doormat doormat;
    //public SpriteChangeAfterPuzzle gateSpriteChange;

    //this is not a good solution but i need to fix the sprite for the expo
    public SpriteChangeAfterPuzzle gateSpriteChange1;
    public SpriteChangeAfterPuzzle gateSpriteChange2;
    public GameObject gateSprite;

    public GameObject gateStop;

    private bool dialoguPlayed = false;
 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "gateCollider" && doormat.openDoormat == true)
        {
            //gateSpriteChange.myPuzzleGotCompleted();
            //this is an AWFUL solution for the expo
            gateSpriteChange1 = gateSpriteChange1.GetComponent<SpriteChangeAfterPuzzle>();
            gateSpriteChange1.myPuzzleGotCompleted();
            gateSpriteChange2 = gateSpriteChange2.GetComponent<SpriteChangeAfterPuzzle>();
            gateSpriteChange2.myPuzzleGotCompleted();


            gateSprite.SetActive(false);

            gateStop.gameObject.SetActive(false);

            //as to not play the dialogue again by accident
            if (!dialoguPlayed)
            {
                dialogueRunner.StartDialogue("P1_Brama_fin");
                dialoguPlayed=true;
            }
        }

    }
}
