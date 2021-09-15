using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Goal"))
        {
            score++;
        }
    }
}
