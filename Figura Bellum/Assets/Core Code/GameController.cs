using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private static GameController mInstance;

    private PlayerScript mPlayerScript;

    private XPBarScript mXPBarScript;

    private GameController()
    {
        //Should load the character save file in here.

    }

    internal void SetXPBarScript(XPBarScript iXPBarScript)
    {
        mXPBarScript = iXPBarScript;
    }

    public static PlayerScript PlayerScript => GetInstance().mPlayerScript;

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
        if (mPlayerScript != null)
            return;
        mPlayerScript = ps;
    }

    public PlayerScript GetPlayerScript()
    {
#warning Player not being set is not handled.
        //Handle if the player is not set.
        return mPlayerScript;
    }

    public static void GiveXP(int XPValue)
    {
        GetInstance().mPlayerScript.GiveXP(XPValue);
    }

    public static void UpdateLevelUI(int level, float xp)
    {
        GetInstance().mXPBarScript.SetLevel(level);
        GetInstance().mXPBarScript.SetPercentage(xp);
    }
}
