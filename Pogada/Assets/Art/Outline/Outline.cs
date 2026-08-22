using UnityEngine;

public class Outline : MonoBehaviour
{
    private Renderer ObjectRenderer;
    void Start()
    {
        ObjectRenderer = GetComponent<Renderer>();
        //turns off outline at start
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }


    private void OnMouseOver()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 1.1f);
    }

    private void OnMouseExit()
    {
        ObjectRenderer.material.SetFloat("_OutlineActive", 0.0f);
    }
}
