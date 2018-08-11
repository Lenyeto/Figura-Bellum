using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlWind : AbilityCore {
    public GameObject mWhirlWind;

    public override void Cast()
    {
        if (cooldown > 0)
            return;

        Destroy(Instantiate(mWhirlWind, gameObject.transform.parent.position, mWhirlWind.transform.rotation, gameObject.transform.parent), 45);

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
