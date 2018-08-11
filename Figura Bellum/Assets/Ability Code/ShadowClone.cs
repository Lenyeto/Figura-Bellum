using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowClone : AbilityCore {
    public override void Cast()
    {
        if (GetComponentInParent<PlayerScript>().isClone)
            return;
        if (cooldown > 0)
            return;
        PlayerScript ps = GameController.GetInstance().GetPlayerScript();

        GameObject clone;
        (clone = Instantiate(ps.gameObject, ps.gameObject.transform.position + new Vector3(0, 3), new Quaternion(0, 0, 0, 0), null)).GetComponent<PlayerScript>().isClone = true;
        Destroy(clone, 5);
        (clone = Instantiate(ps.gameObject, ps.gameObject.transform.position + new Vector3(0, -3), new Quaternion(0, 0, 0, 0), null)).GetComponent<PlayerScript>().isClone = true;
        Destroy(clone, 5);
        (clone = Instantiate(ps.gameObject, ps.gameObject.transform.position + new Vector3(3, 0), new Quaternion(0, 0, 0, 0), null)).GetComponent<PlayerScript>().isClone = true;
        Destroy(clone, 5);
        (clone = Instantiate(ps.gameObject, ps.gameObject.transform.position + new Vector3(-3, 0), new Quaternion(0, 0, 0, 0), null)).GetComponent<PlayerScript>().isClone = true;
        Destroy(clone, 5);

        cooldown = defaultCooldown;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (cooldown > 0)
            cooldown -= Time.deltaTime;
	}
}
