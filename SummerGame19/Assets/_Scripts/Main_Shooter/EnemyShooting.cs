using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject EnemybulletPrefab;
    public float fireRate;
    private float nextFire;

    private void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(EnemybulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
