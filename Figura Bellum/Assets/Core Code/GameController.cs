using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private static GameController mInstance;

    private PlayerScript mPlayerScript;

    private GameController()
    {
        //Should load the character save file in here.
    }

    public static GameController GetInstance()
    {
        if (mInstance == null)
        {
            mInstance = new GameController();
        }
        return mInstance;
    }

    public void SetPlayerScript(PlayerScript ps)
    {
        mPlayerScript = ps;
    }

    public PlayerScript GetPlayerScript()
    {
#warning Player not being set is not handled.
        //Handle if the player is not set.
        return mPlayerScript;
    }
}
