using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float speed;
    public float shootRate;
    public GameObject laser;
    public Transform laserSpawn;
   
    void Start()
    {
        InvokeRepeating("Shoot",shootRate,shootRate);
    }

    void Shoot()
    {
        Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
    }
}
