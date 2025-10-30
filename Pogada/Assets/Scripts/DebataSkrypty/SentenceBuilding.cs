using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SentenceBuilding : MonoBehaviour
{
    public string word;

    public List<string> sentence = new List<string>();


    public List<string> rightAnswer = new List<string>();

    public TMP_Text budowaneZdanieUI;

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
        if (sentence.SequenceEqual(rightAnswer))
        {
            Debug.Log("wygrana");
            budowaneZdanieUI.text = "Poprawna odpowiedü!";
        }

        else
        {
            Debug.Log("fail");
            budowaneZdanieUI.text = "Z≥a odpowiedü!";
        }

        sentence.Clear();
    }

}
