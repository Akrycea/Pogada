using UnityEngine;

public class Outline : MonoBehaviour
{
    private Renderer ObjectRenderer;
    [SerializeField] private float outlineWidth;
    void Start()
    {
        ObjectRenderer = GetComponent<Renderer>();
        //turns off outline at start
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }


    private void OnMouseOver()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 1.1f);
        ObjectRenderer.material.SetFloat("_OutlineSize", outlineWidth);
    }

    private void OnMouseExit()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }
}
