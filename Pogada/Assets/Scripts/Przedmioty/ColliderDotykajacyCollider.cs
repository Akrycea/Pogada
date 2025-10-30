using TMPro.Examples;
using UnityEngine;

public class ColliderDotykajacyCollider : MonoBehaviour
{
    public string ObjectName;
    public bool KluczMinigierka;
    public bool ChmuryMinigierka;

    //odniesienie do puzzle minigierka
    public PuzzleMinigierka puzzleMinigierka;

    //odniesienie do licznika chmur
    public ChmuryMinigierka chMinigierka;

    //odniesienie do gracza
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == ObjectName)
        {
            Debug.Log("kolizja dotyka desired kolizji");

            if (ChmuryMinigierka)
            {
                puzzleMinigierka.Puzzle();
                chMinigierka.doneSteps++;
            }
        }

    }

}
