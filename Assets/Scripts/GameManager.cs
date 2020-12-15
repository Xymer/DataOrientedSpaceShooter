using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.Entities;

public class GameManager : MonoBehaviour
{
    public static GameManager main;

    public GameObject enemyPrefab;

    public float xBounds = 9.5f;
    public float yBound = 4.5f;

    public float enemySpeed = 5f;
    public float enemiesPerWave = 5;
    public float waveSpawnDelay = 10f;
    public int waveCount = 0;
    public int score = 0;
    public int playerLives = 3;

    public Text scoreText;
    public Text playerLivesText;

    Entity enemyEntityPrefab;
    EntityManager entityManager;

    WaitForSeconds oneSecond;
    WaitForSeconds waveDelay;

    private void Awake()
    {
        if (main != null && main != this)
        {
            Destroy(gameObject);
        }

        main = this;
        score = 0;

        oneSecond = new WaitForSeconds(1f);
        waveDelay = new WaitForSeconds(waveSpawnDelay);
    }
}
