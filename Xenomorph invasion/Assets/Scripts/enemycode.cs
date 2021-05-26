using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TO DO: adjusting health, damage and speed for different enemies

public class enemycode : MonoBehaviour
{
    private int damage = 1;
    private int health = 100;
    private float speed = 30;
    //private float waitTime;
    //private float startwaitTime = 5;
    private float distanceCheckpoint = 0.005f;

    public Transform spawnSpot;
    public Transform endPoint;

    public Transform[] movetospots;
    private Transform currentWave;

    private int index = 0;
    private int y = 0;
    private int location;

    // Start is called before the first frame update
    void Start()
    {
        //waitTime = startwaitTime;
        //spawnAtSpot = Random.Range(0, spawnSpot.Length);

        if (Vector3.Distance(transform.position, spawnSpot.position) < distanceCheckpoint)
        {
            location = 0;
        }
        else
        {
            Debug.Log("enemy niet bij spawnpoint");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (y == 0)
        {
            y = movetospots.Length - 1;
        }

        if (location == index && index<=y)
        {
            currentWave = movetospots[index];
            transform.position = Vector3.MoveTowards(transform.position, currentWave.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, currentWave.position) < distanceCheckpoint)
            {
                /*if (waitTime <= 0)
                {
                    waitTime = startwaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }*/
                
                //Debug.Log("locatie " + x);
                index++;
                location = index;
                

            }
            
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPoint.position) < distanceCheckpoint)
            {
                /*if (waitTime <= 0)
                {
                    waitTime = startwaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }*/
                Finish(damage);
            }
        }

        void Finish(int y)
        {
            //Player.health-y;
            Debug.Log("-" + y + "hp");
            Destroy(gameObject);

        }
        

    }

    /*public void SetSpeed(float s)
    {
        speed = s;
    }

    public void SetDamage(int d)
    {
        damage = d;
    }

    public void SetHealth(int h)
    {
        health = h;
    }*/
}
