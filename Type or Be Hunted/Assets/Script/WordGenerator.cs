using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"open","close","put","both","either","broad","big","small","worse","good","bad","take","big","straw","cool","awesome","amazing"};

    public static string GetRandomWord()
    {
        int randomIndex=Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
