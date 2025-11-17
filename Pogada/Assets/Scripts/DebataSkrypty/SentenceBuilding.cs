using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SentenceBuilding : MonoBehaviour
{
    public string word;

    //budowane przez gracza zdanie, poczatkowo puste i wypelnia sie z klikaniem
    public List<string> sentence = new List<string>();

    //dobrych odpowiedzi mozna zrobic tyle ile potrzeba
    public List<string> rightAnswer = new List<string>();
    public List<string> rightAnswer2 = new List<string>();
    public List<string> rightAnswer3 = new List<string>();
    public List<string> rightAnswer4 = new List<string>();
    public List<string> rightAnswer5 = new List<string>();
    public List<string> rightAnswer6 = new List<string>();

    //mid odpowiedzi mozna zrobic tyle ile potrzeba
    public List<string> midAnswer = new List<string>();
    public List<string> midAnswer2 = new List<string>();
    public List<string> midAnswer3 = new List<string>();
    public List<string> midAnswer4 = new List<string>();

    //pokazuje budowane zdanie na ui
    public TMP_Text budowaneZdanieUI;

    //dialog runner
    public DialogueRunner dialogueRunner;

    void Start()
    {

    }


    void Update()
    {
       

    }

    //tu mozna zrobic ze musisz zaliczyc kilka pod rzad dobrze
    public void checkSentence()
    {
        Debug.Log("Zdanie zbudowane.");

        //sprawdza czy listy sπ takie same i na tej podstawie wygrana/przegrana

        //jesli zdanie jest dobre
        if (sentence.SequenceEqual(rightAnswer))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }
        else if (sentence.SequenceEqual(rightAnswer2))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }
        else if (sentence.SequenceEqual(rightAnswer3))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }
        else if (sentence.SequenceEqual(rightAnswer4))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }
        else if (sentence.SequenceEqual(rightAnswer5))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }
        else if (sentence.SequenceEqual(rightAnswer6))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z");
        }

        //jesli zdanie jest mid
        else if (sentence.SequenceEqual(midAnswer))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Mid odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z_Mid");
        }
        else if (sentence.SequenceEqual(midAnswer2))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Mid odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z_Mid");
        }
        else if (sentence.SequenceEqual(midAnswer3))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Mid odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z_Mid");
        }
        else if (sentence.SequenceEqual(midAnswer4))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Mid odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z_Mid");
        }




        //jesli zdanie jest zle
        else 
        {
            Debug.Log("fail");
            budowaneZdanieUI.text = "Z≥a odpowiedü!";
            dialogueRunner.StartDialogue("M15_Z_Bad");
        }

        sentence.Clear();
    }

}
