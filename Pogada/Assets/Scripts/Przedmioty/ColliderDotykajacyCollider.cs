using TMPro.Examples;
using UnityEngine;

public class ColliderDotykajacyCollider : MonoBehaviour
{
    //wpisujesz nazwe obiektu, ktory ten obiekt ma dotknac
    public string ObjectName;

    //wybierasz ktora minigierke chcesz
    public bool KluczMinigierka;
    public bool ChmuryMinigierka;

    //odniesienie do puzzle minigierka
    public PuzzleMinigierka puzzleMinigierka;
    //odniesienie do licznika chmur
    public ChmuryMinigierka chMinigierka;

    //odniesienie do gracza
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

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

            if (ChmuryMinigierka)
            {
                //tu robi to co jest w puzzle minigierka skrypt
                puzzleMinigierka.Puzzle();
                chMinigierka.doneSteps++;
            }
        }

    }

}
