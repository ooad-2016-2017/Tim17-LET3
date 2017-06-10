using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RestartScript : MonoBehaviour {

    public GameObject startButton;
	public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);

        startButton.SetActive(false);
    }
}
