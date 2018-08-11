using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Camera mMainCamera;

    public GameObject mCrosshair;

    public GameObject mPlayerModel;

    //for crosshair
    [SerializeField]
    [Range(2,6)]
    public float mMaxDelta = 2.0f;

    public GameObject[] mAbilities;


    //temp till we get stats and other systems in
    private float mSpeed = 2.0f;
    public GameObject mFireBallAbility;
    public GameObject mShadowCloneAbility;
    public GameObject mFireNovaAbility;
    public GameObject mUltimateFireNova;

    public bool isClone = false;

    // Use this for initialization
    private void Awake()
    {
        GameController.GetInstance().SetPlayerScript(this);
        mMainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mAbilities = new GameObject[6];
        mFireBallAbility.GetComponent<Projectile>().mSpawnPosition = transform;
        mFireBallAbility.GetComponent<Projectile>().mSpawnDirection = mCrosshair.transform;
        mAbilities[0] = Instantiate(mFireBallAbility, gameObject.transform);
        for (int i = 1; i < 3; ++i)
        {
            mAbilities[i] = new GameObject();
            mAbilities[i].transform.SetParent(gameObject.transform);
            mAbilities[i].AddComponent<AbilityCore>();
        }
        mAbilities[3] = Instantiate(mUltimateFireNova, gameObject.transform);
        mAbilities[4] = Instantiate(mFireNovaAbility, gameObject.transform);
        mAbilities[5] = Instantiate(mShadowCloneAbility, gameObject.transform);
    }

    private void AbilityControl()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))   { mAbilities[0].GetComponent<AbilityCore>().Cast(); }
        if (Input.GetKeyDown(KeyCode.Mouse1))   { mAbilities[1].GetComponent<AbilityCore>().Cast(); }
        if (Input.GetKeyDown(KeyCode.F))   { mAbilities[2].GetComponent<AbilityCore>().Cast(); }
        if (Input.GetKeyDown(KeyCode.Q))   { mAbilities[3].GetComponent<AbilityCore>().Cast(); }
        if (Input.GetKeyDown(KeyCode.E))        { mAbilities[4].GetComponent<AbilityCore>().Cast(); }
        if (Input.GetKeyDown(KeyCode.Space))    { mAbilities[5].GetComponent<AbilityCore>().Cast(); }
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameStateManager.Instance.GetCurrentGameState() == GameState.RUNNING)
        {
            CursorControl();
            AbilityControl();
        }
    }


    private void LateUpdate()
    {
        //fix me later to do a proper lerp, nah
        Vector3 cross = mCrosshair.transform.localPosition * 0.5f;
        Vector3 target = new Vector3(transform.position.x + cross.x, transform.position.y + cross.y, cross.z);

        mMainCamera.transform.position = Vector3.Lerp(mMainCamera.transform.position, target, Time.deltaTime);
        mMainCamera.transform.position = new Vector3(mMainCamera.transform.position.x, mMainCamera.transform.position.y, -400);
    }


    private void CursorControl()
    {
        //Crosshair stuff

        if (Input.GetKey(KeyCode.W)) { transform.Translate(transform.up * mSpeed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.S)) { transform.Translate(-transform.up * mSpeed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.A)) { transform.Translate(-transform.right * mSpeed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.D)) { transform.Translate(transform.right * mSpeed * Time.deltaTime); }

        mCrosshair.transform.position += new Vector3(Input.GetAxis("MouseHorizontal") * Time.deltaTime, Input.GetAxis("MouseVertical") * Time.deltaTime, 0);

        Vector3 cross = mCrosshair.transform.localPosition;

        //keeping crosshair locked in my dude
        if (cross.x >= mMaxDelta) { cross = new Vector3(mMaxDelta, cross.y, cross.z); }
        if (cross.x <= -mMaxDelta) { cross = new Vector3(-mMaxDelta, cross.y, cross.z); }

        if (cross.y >= mMaxDelta) { cross = new Vector3(cross.x, mMaxDelta, cross.z); }
        if (cross.y <= -mMaxDelta) { cross = new Vector3(cross.x, -mMaxDelta, cross.z); }

        mCrosshair.transform.localPosition = cross;

    }
}