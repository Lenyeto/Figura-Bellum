using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillStatus : MonoBehaviour {
    public RawImage mRawImage;

    public Texture2D mLocked;
    public Texture2D mUnlocked;
    public Texture2D mObtained;

    /// <summary>
    /// Changes the color behind the skill.
    /// </summary>
    /// <param name="i">0 is locked, 1 is able to be unlocked, 2 is when the skill is obtained.</param>
    public void ChangeStatus(int i)
    {
        switch (i)
        {
            case 0:
                mRawImage.texture = mLocked;
                break;
            case 1:
                mRawImage.texture = mUnlocked;
                break;
            case 2:
                mRawImage.texture = mObtained;
                break;
        }
    }
}
