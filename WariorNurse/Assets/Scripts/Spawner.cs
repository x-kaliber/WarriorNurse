using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float DecreaseTime;
    public float MinTime = 0.65f;

    public void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if (StartTimeBtwSpawn > MinTime)
            {
                StartTimeBtwSpawn -= DecreaseTime;
            }
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
