﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public int Damage = 1;
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Health -= Damage;
            Debug.Log("Awww the pain...." + other.GetComponent<Player>().Health);
                Destroy(gameObject);
        }
    }
}