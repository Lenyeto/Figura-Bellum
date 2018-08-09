using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {

    float defaultTimeLeft = 100;
    float timeLeft = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            Debug.Log(timeLeft);
        }
        GetComponent<SpriteRenderer>().material.SetFloat("_Cutoff", timeLeft / defaultTimeLeft);
	}
}
