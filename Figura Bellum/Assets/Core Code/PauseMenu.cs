using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject[] mMenuOptions;
    private GameState mPrevGameState;

    // Use this for initialization
    private void Start()
    {
        SetEnabled(false);
        mPrevGameState = GameStateManager.Instance.GetCurrentGameState();
    }

    // Update is called once per frame
    private void Update()
    {
        if (mPrevGameState != GameState.PAUSED)
        {
            if (GameStateManager.Instance.GetCurrentGameState() == GameState.PAUSED)
            {
                
                SetActive(0);
            }
        }
        else
        {
            if (GameStateManager.Instance.GetCurrentGameState() == GameState.RUNNING)
            {

                SetEnabled(false);
            }

        }
        mPrevGameState = GameStateManager.Instance.GetCurrentGameState();
    }

    private void SetEnabled(bool b = true)
    {
        for (int i = 0; i < mMenuOptions.Length; ++i)
        {
            mMenuOptions[i].SetActive(b);
        }
    }

    public void SetActive(int option)
    {
        for (int i = 0; i < mMenuOptions.Length; ++i)
        {
            mMenuOptions[i].SetActive(i == option ? true : false);
        }
    }
}