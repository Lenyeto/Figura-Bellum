using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyScript : MonoBehaviour
{
    public float mHealth = 20;

    public float mDefaultInvulnerability = 1;
    public float mInvulnerability = 0;

    float AnimateProgress = 0;
    bool Right = true;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameStateManager.CurrentGameState == GameState.RUNNING)
        {
            Animate();

            //gameObject.transform.Translate((GameController.GetInstance().GetPlayerScript().transform.position - transform.position).normalized * Time.deltaTime);

            Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
            gameObject.GetComponent<Rigidbody2D>().AddForce((GameController.PlayerScript.transform.position - transform.position).normalized);
            
            if (mHealth <= 0)
            {
                Destroy(this.gameObject);
            }

            if (mInvulnerability > 0)
                mInvulnerability -= Time.deltaTime;
        }
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hero Damage" && mInvulnerability <= 0)
        {
            float damage = collision.gameObject.GetComponent<HazardScript>().getDamage();
            mHealth -= damage;
            mInvulnerability = mDefaultInvulnerability;
            gameObject.GetComponent<NumberThrow>().ThrowNumber((int)damage);
        }
    }
}
