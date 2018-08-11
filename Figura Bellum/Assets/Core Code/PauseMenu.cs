using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject[] mMenuOptions;
    public GameObject[] mMenuButtons;
    private GameState mPrevGameState;

    // Use this for initialization
    private void Start()
    {
        SetEnabled(false);
        mPrevGameState = GameStateManager.CurrentGameState;
    }

    // Update is called once per frame
    private void Update()
    {
        if (mPrevGameState != GameState.PAUSED)
        {
            if (GameStateManager.CurrentGameState == GameState.PAUSED)
            {
                SetActive(0);
            }
        }
        else
        {
            if (GameStateManager.CurrentGameState == GameState.RUNNING)
            {

                SetEnabled(false);
            }

        }
        mPrevGameState = GameStateManager.CurrentGameState;
    }

    private void SetEnabled(bool b = true)
    {
        for (int i = 0; i < mMenuOptions.Length; ++i)
        {
            mMenuOptions[i].SetActive(b);
            mMenuButtons[i].SetActive(b);
        }

    }

    public void SetActive(int option)
    {
        for (int i = 0; i < mMenuOptions.Length; ++i)
        {
            mMenuOptions[i].SetActive(i == option ? true : false);
            mMenuButtons[i].SetActive(i != option ? true : false);
        }
    }
}