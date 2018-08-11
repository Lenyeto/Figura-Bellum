using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireNova : AbilityCore {

    public GameObject mFireNovaPrefab;

    public override void Cast()
    {
        if (cooldown > 0)
            return;

        Destroy(Instantiate(mFireNovaPrefab, gameObject.transform.parent.position, mFireNovaPrefab.transform.rotation, gameObject.transform.parent), 10);

        cooldown = defaultCooldown;
    }
    
	// Update is called once per frame
	void Update () {
        if (cooldown > 0)
            cooldown -= Time.deltaTime;
	}
}
