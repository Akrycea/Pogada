using UnityEngine;

public class Outline : MonoBehaviour
{
    private Renderer ObjectRenderer;
    public float outlineWidth;
    public bool interactable;
    void Start()
    {
        ObjectRenderer = GetComponent<Renderer>();
        //turns off outline at start
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
        interactable = true;
    }


    private void OnMouseOver()
    {
        if (interactable)
        {
            ObjectRenderer.material.SetFloat("_OutlineActive", 1.1f);
            ObjectRenderer.material.SetFloat("_OutlineSize", outlineWidth);
        }
    }

    private void OnMouseExit()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }
}
