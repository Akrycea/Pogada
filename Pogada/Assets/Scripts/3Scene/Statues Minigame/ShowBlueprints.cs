using UnityEngine;

public class ShowBlueprints : MonoBehaviour
{

    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    public Sprite[] spriteArray;

    public GameObject blueprintsUI;

    public bool done = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnMouseDown()
    {
        if (blueprintsUI.activeInHierarchy == true)
        {
            blueprintsUI.SetActive(false);
            spriteRenderer.sprite = spriteArray[1];
            done = true;
        }
    }
}
