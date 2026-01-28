using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class ColliderTouchingCollider : MonoBehaviour
{
    //wpisujesz nazwe obiektu, ktory ten obiekt ma dotknac
    public string ObjectName;

    //wybierasz ktora minigierke chcesz
    public bool PuzzleMinigame;

    public bool KeyMinigame;
    public bool CloudStairsMinigame;
    public bool Statues;

    //dialoguerunner zeby cos powiedziec po rozwiazaniu zagadki
    private DialogueRunner dialogueRunner;

    //odniesienie do puzzle minigierka
    public PuzzleMinigame puzzleMinigame;

    //odniesienie do licznika chmur
    public CloudStairsMinigame stairsMinigame;

    //odniesienie do bramy, aby zmienic jej sprite
    private SpriteChangeAfterPuzzle gateSpriteChange;
    private GameObject gate;

    public Doormat doormat;

    public StatueControl statueControl;

    //odniesienie do gracza
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    private void Start()
    {
        //to wszystko do gracza jest
        //playerObject = GameObject.Find("Player");
        //player = playerObject.GetComponent<Transform>();
        //Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("kolizja dotyka kolizji");

        //jesli dotknieta kolizja zgadza sie z ta ktora wybralismy to zrob to
        if (collision.gameObject.name == ObjectName)
        {
            Debug.Log("kolizja dotyka desired kolizji");

            if (PuzzleMinigame)
            {
                puzzleMinigame.Puzzle();
            }

            if (CloudStairsMinigame)
            {
                //tu robi to co jest w puzzle minigierka skrypt
                puzzleMinigame.Puzzle();
                stairsMinigame.doneSteps++;
            }


            if (KeyMinigame && doormat.openDoormat == true)
            {
                //odniesienie do bramy, aby zmienic jej sprite
                gateSpriteChange = GameObject.Find("gateSprite").GetComponent<SpriteChangeAfterPuzzle>();
                //zmienia sprite bramy
                gateSpriteChange.myPuzzleGotCompleted();

                gate = GameObject.Find("gateStop");
                gate.gameObject.SetActive(false);

                dialogueRunner = GameObject.Find("Dialogue System").GetComponent<DialogueRunner>();
                dialogueRunner.StartDialogue("P1_Brama_fin");
            }

            if (Statues)
            {
                puzzleMinigame.Puzzle();

                gameObject.tag = "CZplaceable";
                statueControl.Status();
            }
            
        }

    }

}
