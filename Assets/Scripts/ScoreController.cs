using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    private int score;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("we colide");

        if(collision.tag == "Enemy")
        {
            score++;
            scoreText.text = "Cars Avoided: " + score;
           // Debug.Log(score);
            PlayerPrefs.SetInt("Score", score);
        }
    }
}
