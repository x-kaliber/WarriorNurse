using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float Speed;

    public float EndX;
    public float StartX;

    private void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);

        if(transform.position.x <= EndX)
        {
            Vector2 pos = new Vector2(StartX, transform.position.y);
            transform.position = pos;
        }
    }
}
