using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyScript : MonoBehaviour
{
    float AnimateProgress = 0;
    bool Right = true;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Animate();

        gameObject.transform.Translate((GameController.GetInstance().GetPlayerScript().transform.position - transform.position).normalized * Time.deltaTime);
	}

    void Animate()
    {
        if (Right)
            AnimateProgress += Time.deltaTime;
        else
            AnimateProgress -= Time.deltaTime;

        if (AnimateProgress > 0.2)
            Right = false;
        if (AnimateProgress < -0.2)
            Right = true;

        gameObject.transform.Rotate(Vector3.forward, Right?-1:1);
        //gameObject.transform.Rotate(new Vector3(0, 0, 10));
    }
}
