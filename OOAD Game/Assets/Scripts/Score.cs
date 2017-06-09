using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {


    public Text scoreText;

    public int brojac;

    private int score;
	// Use this for initialization
	void Start () {

        score = 0;
        UpdateScore();
	}
    private void OnTriggerEnter2D()
    {
        score += brojac;
        UpdateScore();

    }
    void UpdateScore()

    {

        scoreText.text = "Points: " + score.ToString();

    }
}
