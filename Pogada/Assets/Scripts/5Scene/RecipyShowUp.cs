using UnityEngine;

public class RecipyShowUp : MonoBehaviour
{

    [SerializeField] private GameObject recipe;


    public void OnMouseDown()
    {
        gameObject.SetActive(false);
        recipe.SetActive(true);
    }
}

