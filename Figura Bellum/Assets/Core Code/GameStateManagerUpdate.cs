using UnityEngine;

public class GameStateManagerUpdate : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        if (GameStateManager.CurrentGameState == GameState.RUNNING) Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.V)) GameStateManager.Instance.SetDebug(!GameStateManager.DebugMode);
     
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (GameStateManager.CurrentGameState)
            {
                case GameState.RUNNING:
                    GameStateManager.Instance.SetNewGameState(GameState.PAUSED);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    break;

                case GameState.PAUSED:
                    GameStateManager.Instance.SetNewGameState(GameState.RUNNING);                   
                    Cursor.lockState = CursorLockMode.Locked;
                    break;
            }
        }
    }
}