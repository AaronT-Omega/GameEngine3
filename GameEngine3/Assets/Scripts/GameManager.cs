
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : Singleton<GameManager>
{
    public EnemySpawner badSpawner;
    public FruitSpawner melonSpawner;

    public int currentScore = 0;
    public int currentHP = 3;
    public float xRange = 15f;
    

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthPoints;


    void Start()
    {

        Enemy enemy = badSpawner.SpawnEnemy();
        Fruit fruit = melonSpawner.SpawnFruit();


        enemy.Attack();
        fruit.Reward();
    }

    private void Update()
    {
        UpdateScoreDisplay();
        UpdateHealthDisplay();

        melonSpawner.randomPos = new Vector3(UnityEngine.Random.Range(-(xRange), xRange), UnityEngine.Random.Range(-5f, 0), 0);
    }


    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }
    void UpdateHealthDisplay()
    {
        if (healthPoints != null)
        {
            healthPoints.text = "HP: " + currentHP.ToString();
        }
    }
}



