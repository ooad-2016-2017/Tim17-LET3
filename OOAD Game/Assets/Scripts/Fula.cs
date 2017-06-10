using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fula : MonoBehaviour {


    public Score score;

    private void OnTriggerEnter2D(Collider2D Toca)
    {
        
        if(Toca.gameObject.tag == "TocaPuna")
        {
            score.lives--;

            score.UpdateLives();
        }

    }
}
