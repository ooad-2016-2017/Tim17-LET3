using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorSkripta : MonoBehaviour {

    public Camera kamera;
    public GameObject piva;

    private float maxWidth;
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

        StartCoroutine(Spawn ());
    }

    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(2.0f);
        while(true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);


            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(piva, spawnPosition, spawnRotation);

            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }

        
    }
    
}
