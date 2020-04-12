using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;
    public float increment;
    public float MaxHeight;
    public float MinHeight;
    public float KeyDelay = 1f;
    public int Health;

    private float timePassed = 0f;
    private Vector2 targetPos;



    private void Update()
    {
        timePassed += Time.deltaTime;


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && timePassed > KeyDelay && transform.position.y < MaxHeight  || Input.GetKeyDown(KeyCode.W) && timePassed > KeyDelay && transform.position.y < MaxHeight )
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
            timePassed = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && timePassed > KeyDelay && transform.position.y > MinHeight || Input.GetKeyDown(KeyCode.S) && timePassed > KeyDelay && transform.position.y > MinHeight)
        {

            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
            timePassed = 0f;
        }
    }
}