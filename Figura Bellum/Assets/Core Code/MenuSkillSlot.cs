using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSkillSlot : MonoBehaviour {
    public int mSlot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Image>().sprite = GameController.GetInstance().GetPlayerScript().mAbilities[mSlot].GetComponent<AbilityCore>().mIcon;
		
	}
}
