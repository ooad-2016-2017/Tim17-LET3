using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {


    public Text scoreText;
    public int lives;
    public Text livesText;
    public int brojac;

    public int score;
	// Use this for initialization
	void Start () {

        lives = 3;
        score = 0;
        UpdateScore();
        UpdateLives();
	}
    /*
    private void OnTriggerEnter2D()
    {
        

    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("TocaPrazna"))
        {
            lives--;
            UpdateLives();
        }

        if (collision.gameObject.tag == "TocaPuna")
        {
            score += brojac;
            UpdateScore();

        }

        
    }
    void UpdateScore()

    {

        scoreText.text = "Points: " + score.ToString();

    }

    public void UpdateLives()
    {
        livesText.text = "Lives: " + lives.ToString();
    }
}
