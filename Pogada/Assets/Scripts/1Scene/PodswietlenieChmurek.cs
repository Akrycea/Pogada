using UnityEngine;

public class PodswietlenieChmurek : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject Obiekt;
    void Start()
    {
        spriteRenderer = Obiekt.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        
    }

    public void GetMouseButton()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 30);
    }
}
