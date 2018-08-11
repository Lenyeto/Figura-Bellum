using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject mMenuObj;
    public int mMenuNumber;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void  OnMouseDown()
    {
        Debug.Log("Clicked: " + mMenuNumber);
    }
}
