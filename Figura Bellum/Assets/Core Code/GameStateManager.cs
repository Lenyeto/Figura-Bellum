using UnityEngine;

public enum GameState { MENU, RUNNING, PAUSED, CUTSCENE };

public sealed class GameStateManager
{
    private static readonly GameStateManager msInstance = new GameStateManager();

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit

    private GameObject mGameManagerObject;

    private GameState mCurrentGameState = GameState.RUNNING;

    static GameStateManager()
    {
    }

    private GameStateManager()
    {
        Debug.Log("Creating GameStateManager");
        mGameManagerObject = new GameObject("GameStateManager");
        mGameManagerObject.AddComponent<GameStateManagerUpdate>();
    }

    public GameState GetCurrentGameState()
    {
        return mCurrentGameState;
    }

    public void SetNewGameState(GameState state)
    {
        mCurrentGameState = state;
    }

    public static GameStateManager Instance
    {
        get
        {
            return msInstance;
        }
    }
}