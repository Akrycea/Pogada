using TMPro.Examples;
using UnityEngine;

public class ColliderTouchingCollider : MonoBehaviour
{
    //wpisujesz nazwe obiektu, ktory ten obiekt ma dotknac
    public string ObjectName;

    //wybierasz ktora minigierke chcesz
    public bool KeyMinigame;
    public bool CloudStairsMinigame;

    //odniesienie do puzzle minigierka
    public PuzzleMinigame puzzleMinigame;
    //odniesienie do licznika chmur
    public CloudStairsMinigame stairsMinigame;

    //odniesienie do bramy, aby zmienic jej sprite
    private SpriteChangeAfterPuzzle bramaSpriteChange;
    private GameObject gate;

    //odniesienie do gracza
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    public Doormat doormat;
    public Drag drag;

    private void Start()
    {
        //to wszystko do gracza jest
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //jesli dotknieta kolizja zgadza sie z ta ktora wybralismy to zrob to
        if (collision.gameObject.name == ObjectName)
        {
            Debug.Log("kolizja dotyka desired kolizji");

            if (CloudStairsMinigame)
            {
                //tu robi to co jest w puzzle minigierka skrypt
                puzzleMinigame.Puzzle();
                stairsMinigame.doneSteps++;
            }
            else if (KeyMinigame && doormat.openDoormat == true)
            {
                //odniesienie do bramy, aby zmienic jej sprite
                bramaSpriteChange = GameObject.Find("bramaSprite").GetComponent<SpriteChangeAfterPuzzle>();
                //zmienia sprite bramy
                bramaSpriteChange.myPuzzleGotCompleted();

                gate = GameObject.Find("bramaStop");
                gate.SetActive(false);
            }
        }

    }

}
