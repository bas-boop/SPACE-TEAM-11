using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;
    public float speed;
    private Transform target;
    Vector3 dir;
    public basicenemycode changeEnemyStats;

    public void Seek (Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            //HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    /*void HitTarget()
    {
        if (target != null)
        {
            
        }
        //changeEnemyStats.TakeDamage(damage);
        Destroy(gameObject);
        
        
    }  */
}
