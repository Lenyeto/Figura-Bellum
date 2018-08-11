using UnityEngine;

public class GameStateManagerUpdate : MonoBehaviour
{
    // Use this for initialization
    private void Awake()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (GameStateManager.Instance.GetCurrentGameState())
            {
                case GameState.RUNNING:
                    GameStateManager.Instance.SetNewGameState(GameState.PAUSED);
                    //Cursor.lockState = CursorLockMode.Locked;
                    break;

                case GameState.PAUSED:
                    GameStateManager.Instance.SetNewGameState(GameState.RUNNING);
                    //Cursor.lockState = CursorLockMode.None;
                    break;
            }
        }
    }
}