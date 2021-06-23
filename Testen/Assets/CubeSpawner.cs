using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;

    private int x;
    private float counter = 0;
    private float waitTime = 2;
    private float spawnAmount = 0;
    private float cubeDistance = 1.5f;

    private bool cubeSpawnerStarted = false;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    public void Update()
    {
        StartCubeSpawner();
    }

    public void StartCubeSpawner()
    {
        counter += Time.deltaTime;
        if (spawnAmount <= 20 && counter >= waitTime)
        {
            Debug.Log("for loop #" + spawnAmount);
            Debug.Log("Spawning Cubes");
            SpawnCubes();
            counter = 0;
            spawnAmount++;
        }
        
    }
    // Update is called once per frame
    public void SpawnCubes()
    {
        Vector3 spawnposition = new Vector3(spawnAmount * cubeDistance, 0, 0);
        Instantiate(cube, spawnposition, transform.rotation);
    }

}
