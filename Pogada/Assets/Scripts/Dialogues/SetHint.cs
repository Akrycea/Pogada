using UnityEngine;

public class SetHint : MonoBehaviour
{
    [SerializeField] private string nextHint;
    [SerializeField] private HintsPlaying hintsPlaying;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            hintsPlaying.nextHint = nextHint;
            hintsPlaying.readyToSayHint = false;
            hintsPlaying.playingHints = true;
            hintsPlaying.countingDown = true;
            gameObject.SetActive(false);
        }
    }


}
