using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{
    private Transform target;
    public float range = 15f;

    public string enemyTag = "Enemy";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public float startShootCooldown = 1f;
    private float shootCooldown;

    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 2f;
    Vector3 dir;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);

    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;


        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return;

        dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed * 10).eulerAngles;
        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);
        Shoot();
    }

    void Shoot()
    {
        
        
        if (shootCooldown < Time.time)
        {
            
            shootCooldown = Time.time + startShootCooldown;
            GameObject go = Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            //go.GetComponent<Bullet>().dir = dir.normalized;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}