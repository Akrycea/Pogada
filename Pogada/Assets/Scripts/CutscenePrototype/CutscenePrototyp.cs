using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenePrototyp : MonoBehaviour
{
    //spritey do zmiany artu
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    //int ile razy sie kliknelo
    private int p;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //ustawiamy pierwszy art na poczatku
        spriteRenderer.sprite = sprites[0];

        //zerujemy kliki na poczatku
        p = 0;
    }
    private void OnMouseDown()
    {
        //sprawdza jaki jest art i ustawia nastepny
        if (spriteRenderer.sprite == sprites[0])
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (spriteRenderer.sprite == sprites[1])
        {
            spriteRenderer.sprite = sprites[2];
        }
        //liczy klik i dodaje go do licznika
        p++;
    }

    private void Update()
    {
        //jesli klikniemy dostateczna ilosc razy to nastepna scena
        if (p>=3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
