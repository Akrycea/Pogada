using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro.Examples;
using UnityEngine;
using Yarn.Unity;

public class PotionMinigame : MonoBehaviour
{
    public GameObject[] recipe;

    public GameObject[] playersItems;

    public int currentObject;

    public List<IngredientControl> myIngredients = new();

    [SerializeField] private DebataPlayer debataPlayer;

    public DialogueRunner dialogueRunner;

    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;

    void OnTriggerEnter2D(Collider2D collision)
    {
        playersItems[currentObject] = collision.gameObject;
        playRandomSound();
        currentObject++;
        collision.gameObject.SetActive(false);

        if (playersItems.Length == currentObject)
        {
            if (recipe.SequenceEqual(playersItems))
            {
                Debug.Log("Win");
                debataPlayer.wygranaMinigierka = true;
                dialogueRunner.StartDialogue("P8_Potka_fin");
                debataPlayer.SentenceBuildingStart();
            }
            else
            {
                Debug.Log("loss");
                ResetIngredients();
                System.Array.Clear(playersItems, 0, playersItems.Length);
                currentObject = 0;
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

    private void  playRandomSound()
    {
        AudioClip randomClip = audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
        audioSource.PlayOneShot(randomClip);
    }

}
