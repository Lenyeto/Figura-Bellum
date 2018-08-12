using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberThrow : MonoBehaviour {

    public GameObject NumberHolderPrefab;
    Random r = new Random();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ThrowNumber(int i)
    {
        //DO NOT MAKE THIS A CHILD, WHEN AN ENEMY DIES, THE NUMBER SHOULD STILL BE THERE.
        GameObject go = Instantiate(NumberHolderPrefab, gameObject.transform.position, new Quaternion());
        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, NumberHolderPrefab.transform.position.z);


        go.GetComponent<Rigidbody2D>().AddForce(new Vector2((Random.value / 2), (Random.value / 2) + 0.5f) * 200);

        go.GetComponent<TextMesh>().text = i.ToString();

        Destroy(go, 5);
    }

    //Used for crit damage at one point.
    public void ThrowNumberColored(int i, Color color)
    {

    }
}
