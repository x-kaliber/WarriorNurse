using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public float speed;
    public float increment;
    public float MaxHeight;
    public float MinHeight;
    public float KeyDelay = 1f;
    public float TimedDmG = 10f;

    public int Health = 3;
    public int SHealth = 100;

    public GameObject Effect;
    public GameObject GameOver;
    public GameObject ScoreManager;

    public Text HealthDisplay;
    public Text StaminaDisplay;

    public bool lost;


    private float timePassed = 0f;
    private float timeElapsed = 0f;
    private Vector2 targetPos;


    private void Update()
    {
        HealthDisplay.text = Health.ToString();
        StaminaDisplay.text = SHealth.ToString();

        if (Health <= 0)
        {
            ScoreManager.SetActive(false);
            GameOver.SetActive(true);
            Destroy(gameObject);
        }
        if (SHealth <= 0)
        {
            ScoreManager.SetActive(false);
            GameOver.SetActive(true);
            Destroy(gameObject);
        }

        timePassed += Time.deltaTime;
        timeElapsed += Time.deltaTime;


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && timePassed > KeyDelay && transform.position.y < MaxHeight  || Input.GetKeyDown(KeyCode.W) && timePassed > KeyDelay && transform.position.y < MaxHeight )
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
            timePassed = 0f;
            FindObjectOfType<AudioManager>().Play("Step");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && timePassed > KeyDelay && transform.position.y > MinHeight || Input.GetKeyDown(KeyCode.S) && timePassed > KeyDelay && transform.position.y > MinHeight)
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
            timePassed = 0f;
            FindObjectOfType<AudioManager>().Play("Step");
        }

        if(timeElapsed >= TimedDmG)
        {
            SHealth -= 2;
            timeElapsed = 0f;
        }
    }
}