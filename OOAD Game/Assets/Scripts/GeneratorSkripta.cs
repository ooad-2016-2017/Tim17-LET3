using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorSkripta : MonoBehaviour {

    public Camera kamera;
    public GameObject[] pive;
    private float maxWidth;
    public GameObject gameOverText;
    public GameObject restartButton;
    public GameObject startButton;
    public KontrolerSkripta kontroler;
    public Score score;
    // Use this for initialization
    void Start()
    {
        
    
        if (kamera == null)
        {
            kamera = Camera.main;
        }

        Vector3 gornjiCosak = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetSirina = kamera.ScreenToWorldPoint(gornjiCosak);
        float sirinaTacne = GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetSirina.x - sirinaTacne;

        
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        kontroler.ToggleControl(true);
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(0.5f);
        while(score.lives > 0)
        {
            GameObject piva = pive[Random.Range(0, pive.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);


            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(piva, spawnPosition, spawnRotation);

            //yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));

            
            if (score.score < 10)
            {
                yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
            }
            else if(score.score >= 10 && score.score < 20)
            {
                yield return new WaitForSeconds(Random.Range(0.8f, 1.4f));
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(0.2f, 0.5f));
            }
            
            
        }

        gameOverText.SetActive(true);

        restartButton.SetActive(true);
        
    }
    
}
