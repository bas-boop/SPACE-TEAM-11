using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 0;
    private float speed = 30f;
    private Transform target;
    private basicenemycode changeEnemyStats;

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
        
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * 10 * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {

        //changeEnemyStats.EnemyTakeDamage(damage);
        Destroy(target.gameObject);
        Destroy(gameObject);
        
        
    }  
}
