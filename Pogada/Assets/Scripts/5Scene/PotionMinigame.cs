using TMPro.Examples;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class PotionMinigame : MonoBehaviour
{
    public GameObject[] recipe;

    public GameObject[] playersItems;

    public int currentObject;

    public List<IngredientControl> myIngredients = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        playersItems[currentObject] = collision.gameObject;
        currentObject++;
        collision.gameObject.SetActive(false);

        if (playersItems.Length == currentObject)
        {
            if (recipe.SequenceEqual(playersItems))
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.Log("loss");
                ResetIngredients();
            }
        }
    }

    public void ResetIngredients()
    {
        foreach (var item in playersItems)
        {
            Debug.Log("dzais");
            //item.SetActive(true);
            item.GetComponent<IngredientControl>().ReturnToPosition();
        }
    }

}
