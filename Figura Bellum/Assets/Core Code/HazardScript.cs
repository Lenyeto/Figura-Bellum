using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour {
    public bool destroyOnDamage = true;
    public float mDamage = 5;

    public bool isChangingCollider = false;
    public float CurrentSize;
    public float StartingSize = 10;
    public float EndingSize = 20;
    public float ColliderChangeSpeed = 1.0f;

    public CircleCollider2D mCollider;

    public GameObject mainGameObject;

	// Use this for initialization
	void Start () {
        CurrentSize = StartingSize;
        if (mainGameObject == null)
            mainGameObject = gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (isChangingCollider)
            ChangeCollider();
	}

    public float getDamage()
    {
        if (destroyOnDamage)
        {
            Destroy(mainGameObject);
        }
        return mDamage;
    }

    public void ChangeCollider()
    {
        if (CurrentSize > EndingSize)
            return;
        mCollider.radius = CurrentSize;
        CurrentSize += Time.deltaTime * ColliderChangeSpeed;
    }
}
