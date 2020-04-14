using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destryer : MonoBehaviour
{
    public float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
