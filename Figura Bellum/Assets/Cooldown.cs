using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {

    public Image mImage;
    public int mAbilityID;

    //float defaultTimeLeft = 100;
    //float timeLeft = 100;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.GetInstance().GetPlayerScript() == null)
        {
            Debug.Log(GameController.GetInstance().GetPlayerScript());
            return;
        }
        //Debug.Log(GameController.GetInstance().GetPlayerScript());
        mImage.fillAmount = GameController.GetInstance().GetPlayerScript().mAbilities[mAbilityID].GetComponent<Projectile>().cooldown / GameController.GetInstance().GetPlayerScript().mAbilities[mAbilityID].GetComponent<Projectile>().defaultCooldown;
    }
}
