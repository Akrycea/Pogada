using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Word : MonoBehaviour
{
    public SentenceBuilding sentenceScript;
    public TMP_Text budowaneZdanieUI;

    private void OnMouseDown()
    {
        sentenceScript.sentence.Add(gameObject.name);
        Debug.Log("Added word '" + gameObject.name + "' to sentence.");

        if (budowaneZdanieUI.text != "Poprawna odpowied�!" && budowaneZdanieUI.text != "Z�a odpowied�!")
        {
            budowaneZdanieUI.text = budowaneZdanieUI.text + gameObject.name + " ";
        }
        else
        {
            budowaneZdanieUI.text = gameObject.name + " ";
        }
    }
}
