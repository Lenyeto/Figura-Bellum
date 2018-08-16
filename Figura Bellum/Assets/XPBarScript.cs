using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarScript : MonoBehaviour
{
    Image XPBar;
    public Text LevelNumberText;

	// Use this for initialization
	void Start ()
    {
        XPBar = GetComponent<Image>();
        GameController.GetInstance().SetXPBarScript(this);

        XPBar.fillAmount = 0;
        LevelNumberText.text = 0.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetPercentage(float i)
    {
        XPBar.fillAmount = i;
    }

    public void SetLevel(int i)
    {
        LevelNumberText.text = i.ToString();
    }
}
