using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Game Setting")]
    public int maxHealth = 100;
    public int currentHealth;
    public float timer;
    public bool isOver;

    [Header("UI")]
    public TextMeshProUGUI timerTxt;
    public HealthBar healthBar;

    void Start()
    {
        timer = GameData.instance.timerr;
        isOver = false;

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            float minutes = Mathf.FloorToInt(timer / 60);
            float seconds = Mathf.FloorToInt(timer % 60); // mod
            timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        if (timer <= 0f && !isOver)
        {
            timerTxt.text = "00:00";
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            TakeDamage(20);

            healthBar.SetHealth(currentHealth);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
