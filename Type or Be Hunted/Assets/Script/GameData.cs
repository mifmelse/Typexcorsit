using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData instance;
    public float timerr;
    public GameObject[] enemyy;
    public GameObject winCondition;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        enemyy = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("musuh ada: " + enemyy.Length);

        if(enemyy.Length == 0)
        {
            winCondition.SetActive(true);
            // script seluruh game jadi freeze atau terhenti
        }
    }
}
