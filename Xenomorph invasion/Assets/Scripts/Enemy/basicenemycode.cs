using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicenemycode : MonoBehaviour
{
    //enemycode1 enemyOne;
    //enemycode2 enemyTwo;
    Player_Health PH;
    
    private int damage = 1;
    public float health = 0f;
    private float speed = 40;

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
    public string x = ("Banana");

    //public Money money;
    
    // Start is called before the first frame update
    void Start()
    {

        PH = GameObject.Find("Player").GetComponent<Player_Health>();
        //waitTime = startwaitTime;
        //spawnAtSpot = Random.Range(0, spawnSpot.Length);

        //StartCode();
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
            transform.position = Vector3.MoveTowards(transform.position, currentWave.position, speed  * Time.deltaTime);
            transform.LookAt(currentWave.position);

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

        
    }
    
    
    /*void StartCode()
    {
        enemyOne = GetComponent<enemycode1>();
        enemyTwo = GetComponent<enemycode2>();
        if (enemyOne != null)
        {
            enemyOne.GetStats();
        }
        else
        {
            enemyTwo.GetStats();
        }
    }*/
    void Finish(int y)
    {
        //Player.health-y;
        Debug.Log("-" + y + "hp");
        Die();
        GameObject.Find("Player").GetComponent<Player_Health>().TakeDamage(y);
        PH.TakeDamage(1);
    }

    public void TakeDamage(float y)
    {
        health -= y;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        GameObject.Find("Gold Amount").GetComponent<Money>().money += 5;
        Destroy(gameObject);
        Debug.Log(x);
    }
}
