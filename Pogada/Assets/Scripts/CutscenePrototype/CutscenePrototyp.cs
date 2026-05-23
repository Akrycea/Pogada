using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenePrototyp : MonoBehaviour
{
    //spritey do zmiany artu
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Sprite myNewSprite;

    private int counter;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //ustawiamy pierwszy art na poczatku
        spriteRenderer.sprite = sprites[0];

        //zerujemy kliki na poczatku
        counter = 0;
    }
    private void OnMouseDown()
    {
        counter++;
        spriteRenderer.sprite = sprites[counter];

        if (counter >= 3)
        {
            counter = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
