using UnityEngine;

public class Outline : MonoBehaviour
{
    private Renderer ObjectRenderer;
    public float outlineWidth;
    public bool interactable;
    public float alpha;
    void Start()
    {
        ObjectRenderer = GetComponent<Renderer>();
        //turns off outline at start
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
        ObjectRenderer.material.SetFloat("_Alphathreshold", alpha);
        interactable = true;
    }


    private void OnMouseOver()
    {
        if (interactable)
        {
            ObjectRenderer.material.SetFloat("_OutlineActive", 1.1f);
            ObjectRenderer.material.SetFloat("_OutlineSize", outlineWidth);
            ObjectRenderer.material.SetFloat("_Alphathreshold", alpha);
        }
    }

    private void OnMouseExit()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }
}
