using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolerSkripta : MonoBehaviour {

    public Camera kamera;

    private float maxWidth;
	// Use this for initialization
	void Start () {

        //kamera = Camera.main;

        if (kamera == null)
        {
            kamera = Camera.main;
        }

        Vector3 gornjiCosak = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetSirina = kamera.ScreenToWorldPoint(gornjiCosak);
        float sirinaTacne = GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetSirina.x - sirinaTacne;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 pomocni = kamera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pozicija = new Vector3(pomocni.x, -5.0f, 0.0f);

        float sirina = Mathf.Clamp(pozicija.x, -maxWidth, maxWidth);

        pozicija = new Vector3(sirina, pozicija.y, pozicija.z);

        GetComponent<Rigidbody2D>().isKinematic = true;

        GetComponent<Rigidbody2D>().MovePosition(pozicija);
    }
}
