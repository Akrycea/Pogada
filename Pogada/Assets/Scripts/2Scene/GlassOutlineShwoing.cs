using UnityEngine;

public class GlassOutlineShwoing : MonoBehaviour
{
    private SpriteRenderer srenderer;
    void Start()
    {
        srenderer = GetComponent<SpriteRenderer>();
        srenderer.enabled = false;
    }


    private void OnMouseOver()
    {
        Debug.Log("mouse over glass");
       srenderer.enabled = true;
    }

    private void OnMouseExit()
    {
        srenderer.enabled = false;
    }
}
