using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Wave
{
    public string waveName;
    public EnemyGroup[] DifferentEnemies;
    public float spawnInterval;
}

[System.Serializable]
public class EnemyGroup
{
    public GameObject spawnenemy;
    public int noOfEnemies;
}

public class Wavesystem : MonoBehaviour
{
    public Wave[] waves;
    public Transform spawnPoint;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool createdList = false;
    private bool canSpawn;
    private int y;
    
    private int EnemyCountdown;
    List<GameObject> AllEnemiesList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] spawnEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        y = spawnEnemies.Length;
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentWave = waves[currentWaveNumber];
        
        if (canSpawn == true && nextSpawnTime < Time.time)
        {
            EnemyCountdown = AllEnemiesList.Count;
            //Debug.Log(currentWave);
            SpawnWave();
        }
            
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (totalEnemies.Length == y && canSpawn == false && currentWaveNumber + 1 != waves.Length)
        {
            currentWaveNumber++;
            canSpawn = true;
            createdList = false;
        }
    }

    
    void SpawnWave()
    {
        if (createdList == false)
        {
            CreateAllEnemyList();
            createdList = true;
        }
        EnemyCountdown--;
        nextSpawnTime = Time.time + currentWave.spawnInterval;
        GameObject enemy = Instantiate(GetRandomEnemy(), spawnPoint.position, transform.rotation);
        enemy.GetComponent<enemycode>().enabled = true;
        if (EnemyCountdown == 0)
        {
            canSpawn = false;
        }
    }

    GameObject GetRandomEnemy()
    {
        int x = Random.Range(0, AllEnemiesList.Count);
        GameObject enemy = AllEnemiesList[x];
        AllEnemiesList.RemoveAt(x);
        return enemy;
    }

    void CreateAllEnemyList()
    {
        for (int i = 0; i < currentWave.DifferentEnemies.Length; i++)
        {
            for (int x = 0; x < currentWave.DifferentEnemies[i].noOfEnemies; x++)
            {
                AllEnemiesList.Add(currentWave.DifferentEnemies[i].spawnenemy);
            }
        }
        foreach (GameObject g in AllEnemiesList) 
        {
            Debug.Log(g);
        }
        //Debug.Log(AllEnemiesList);
    }
}
