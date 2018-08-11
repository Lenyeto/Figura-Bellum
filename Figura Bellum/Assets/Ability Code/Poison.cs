using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : AbilityCore {
    public GameObject mPoison;

    public override void Cast()
    {
        if (cooldown > 0)
            return;
        
        Destroy(Instantiate(mPoison, gameObject.transform.parent.position, mPoison.transform.rotation, null), 45);

        cooldown = defaultCooldown;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;
	}
}
