using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : AbilityCore {

    public GameObject[] projectiles;
    public Transform spawnPosition;
    public Transform spawnDirection;

    [HideInInspector]
    public int currentProjectile = 0;

    public float speed = 1000;

    public GameObject projectile;


    // Use this for initialization
    void Start () {
		
	}

	override public void Cast()
    {

        GameObject projectile = Instantiate(projectiles[currentProjectile], spawnPosition.position, Quaternion.identity) as GameObject;

        projectile.transform.LookAt(spawnDirection.position);
        projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed);

    }
	// Update is called once per frame
	void Update () {

        

    }
}
