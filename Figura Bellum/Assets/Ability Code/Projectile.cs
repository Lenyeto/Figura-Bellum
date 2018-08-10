using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : AbilityCore {

    
    public Transform mSpawnPosition;
    public Transform mSpawnDirection;

    [HideInInspector]
    public int currentProjectile = 0;

    public float speed = 1000;

    public GameObject mProjectile;


    // Use this for initialization
    void Start () {
		
	}

	override public void Cast()
    {

        GameObject projectile = Instantiate(mProjectile, mSpawnPosition.position, Quaternion.identity) as GameObject;

        projectile.transform.LookAt(mSpawnDirection.position);
        projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed);

    }
	// Update is called once per frame
	void Update () {

        

    }
}
