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

    [SerializeField] private DebataPlayer debataPlayer;


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
                debataPlayer.wygranaMinigierka = true;
                debataPlayer.SentenceBuildingStart();
            }
            else
            {
                Debug.Log("loss");
                ResetIngredients();
                System.Array.Clear(playersItems, 0, playersItems.Length);
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
