using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {
    public Image mSpellIcon;
    public Image mImage;
    public int mAbilityID;
    
    // Use this for initialization
    void Start () {
        mSpellIcon.sprite = GameController.GetInstance().GetPlayerScript().mAbilities[mAbilityID].GetComponent<AbilityCore>().mIcon;
	}

	// Update is called once per frame
	void Update () {
        if (GameController.GetInstance().GetPlayerScript() == null)
        {
            return;
        }
        //Debug.Log(GameController.GetInstance().GetPlayerScript());
        mImage.fillAmount = GameController.GetInstance().GetPlayerScript().mAbilities[mAbilityID].GetComponent<AbilityCore>().cooldown / GameController.GetInstance().GetPlayerScript().mAbilities[mAbilityID].GetComponent<AbilityCore>().defaultCooldown;
    }
}
