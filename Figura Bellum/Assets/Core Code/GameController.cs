using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController {
    private GameController mInstance;

    private GameController()
    {
        //Should load the character save file in here.
    }

    public GameController GetInstance()
    {
        if (mInstance == null)
        {
            mInstance = new GameController();
        }
        return mInstance;
    }


}
