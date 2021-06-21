using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TO DO: adjusting health, damage and speed for different enemies

public class basicenemycode : MonoBehaviour
{
    //enemycode1 enemyOne;
    //enemycode2 enemyTwo;
    Player_Health PH;
    
    private int damage = 1;
<<<<<<< HEAD:Xenomorph invasion/Assets/Scripts/Enemy/basicenemycode.cs
    public int health = 100;
    private float speed = 30;
=======
    private int health = 100;
    private float speed = 40f;
>>>>>>> 6312653fafc5c69825efc1c44073bdfc1a8842c1:Xenomorph invasion/Assets/Scripts/basicenemycode.cs
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

    //public Money money;
    
    // Start is called before the first frame update
    void Start()
    {

        //PH = GameObject.Find("Player").GetComponent<Player_Health>();
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
        //PH.TakeDamage(15);
    }

    public void EnemyTakeDamage(int y)
    {
        health -= y;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //money.Increase(worth);
        Destroy(gameObject);
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
    }

    /*public void SetWorth(int w)
    {
        worth = w;
    }  */  
}
