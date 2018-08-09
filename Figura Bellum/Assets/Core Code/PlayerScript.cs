using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Camera mMainCamera;

    public GameObject mCrosshair;

    public GameObject mPlayerModel;

    //temp till we get stats in
    private float mSpeed = 2.0f;

    //for crosshair
    [SerializeField]
    [Range(2,6)]
    public float mMaxDelta = 2.0f;

    // Use this for initialization
    private void Start()
    {
        mMainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //MOVE THIS LATER
    }

    // Update is called once per frame
    private void Update()
    {
        //Crosshair stuff
        if (GameStateManager.Instance.GetCurrentGameState() == GameState.RUNNING)
        {
            if (Input.GetKey(KeyCode.W)) { transform.Translate(transform.up * mSpeed * Time.deltaTime); }

            if (Input.GetKey(KeyCode.S)) { transform.Translate(-transform.up * mSpeed * Time.deltaTime); }

            if (Input.GetKey(KeyCode.A)) { transform.Translate(-transform.right * mSpeed * Time.deltaTime); }

            if (Input.GetKey(KeyCode.D)) { transform.Translate(transform.right * mSpeed * Time.deltaTime); }

            mCrosshair.transform.position += new Vector3(Input.GetAxis("MouseHorizontal") * Time.deltaTime, Input.GetAxis("MouseVertical") * Time.deltaTime, 0);

            Vector3 cross = mCrosshair.transform.localPosition;

            //keeping crosshair locked in my dude
            if (cross.x >= mMaxDelta) { cross = new Vector3(mMaxDelta, cross.y, cross.z); }
            if (cross.x <= -mMaxDelta) { cross = new Vector3(-mMaxDelta, cross.y, cross.z);}

            if (cross.y >= mMaxDelta) { cross = new Vector3(cross.x, mMaxDelta, cross.z);}
            if (cross.y <= -mMaxDelta){ cross = new Vector3(cross.x, -mMaxDelta, cross.z);}

            mCrosshair.transform.localPosition = cross;
        }
    }

    private void FixedUpdate()
    {

    }

    private void LateUpdate()
    {
        //fix me later to do a proper lerp, nah
        Vector3 cross = mCrosshair.transform.localPosition * 0.5f;
        Vector3 target = new Vector3(transform.position.x + cross.x, transform.position.y + cross.y, cross.z);

        mMainCamera.transform.position = Vector3.Lerp(mMainCamera.transform.position, target, Time.deltaTime);
        mMainCamera.transform.position = new Vector3(mMainCamera.transform.position.x, mMainCamera.transform.position.y, -400);
    }
}