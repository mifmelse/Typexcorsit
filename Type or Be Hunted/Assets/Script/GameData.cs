using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData instance;
    public float timerr;
    public GameObject[] gameObjects;

    private void Awake()
    {
        if(instance != null)
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
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("Game Object Ada =" + gameObjects.Length);

    }

}
