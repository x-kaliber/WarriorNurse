using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public GameObject GameWin;

    public Text scoreDisplay;
    public Text scoreDisplay2;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        scoreDisplay2.text = score.ToString();
        if (score >= 1500) 
        {

                GameWin.SetActive(true);


        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
                // increase Score
                score++;
                Debug.Log("Your Score is :" + score);
        }
    }
}
