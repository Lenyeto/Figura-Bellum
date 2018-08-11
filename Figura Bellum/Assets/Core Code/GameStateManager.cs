using UnityEngine;

public enum GameState { MENU, RUNNING, PAUSED, CUTSCENE };


public sealed class GameStateManager
{


    private static readonly GameStateManager msInstance = new GameStateManager();
    private static bool msDebugMode = false;

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit

    private static GameObject mGameManagerObject;

    private static GameState mCurrentGameState = GameState.RUNNING;

    static GameStateManager()
    {
    }

    private GameStateManager()
    {
        Debug.Log("Creating GameStateManager");
        mGameManagerObject = new GameObject("GameStateManager");
        mGameManagerObject.AddComponent<GameStateManagerUpdate>();
    }

    public void SetNewGameState(GameState state)
    {
        mCurrentGameState = state;
    }

    public void SetDebug(bool b)
    {
        msDebugMode = b;
        
    }

    public static GameStateManager Instance
    {
        get
        {
            return msInstance;
        }
    }

    public static GameState CurrentGameState
    {
        get
        {
            return mCurrentGameState;
        }
    }

    public static bool DebugMode
    {
        get
        {
            return msDebugMode;
        }
    }
}