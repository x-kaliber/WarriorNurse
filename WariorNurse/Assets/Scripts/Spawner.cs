using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] EnemyPatern;

    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float DecreaseTime;
    public float MinTime = 0.65f;

    public void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, EnemyPatern.Length);
            Instantiate(EnemyPatern[rand], transform.position, Quaternion.identity);
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
