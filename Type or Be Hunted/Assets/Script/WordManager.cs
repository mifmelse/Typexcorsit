using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> Words;
    private bool hasActiveWord;
    private Word activeWord;
    public WordSpawner wordSpawner;

    private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
        AddWord();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(),wordSpawner.SpawnWord());
        Debug.Log(word.word);

        Words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if(hasActiveWord)
        {
            if(activeWord.GetNextLetter()==letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in Words)
            {
                if (word.GetNextLetter()== letter)
                {
                    activeWord= word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            Words.Remove(activeWord);
        }
    }
}
