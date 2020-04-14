using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public int Damage = 1;
    public float speed;


    public GameObject Effect;

    private Shake shake;
    
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shake.CamShake();
            Instantiate(Effect, transform.position, Quaternion.identity);

            other.GetComponent<Player>().Health -= Damage;
            FindObjectOfType<AudioManager>().Play("Impact");
            if(other.GetComponent<Player>().Health >= 1)
            {
                FindObjectOfType<AudioManager>().Play("PainSound");
            }
            if (other.GetComponent<Player>().Health == 0)
            {
                FindObjectOfType<AudioManager>().Play("Explosion");
            }
            Debug.Log("Awww the pain...." + other.GetComponent<Player>().Health);
                Destroy(gameObject);
        }
    }
}
