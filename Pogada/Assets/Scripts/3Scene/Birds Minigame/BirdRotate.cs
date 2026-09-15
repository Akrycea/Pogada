using UnityEngine;

public class BirdRotate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().flipY = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().flipY = false;
    }
}
