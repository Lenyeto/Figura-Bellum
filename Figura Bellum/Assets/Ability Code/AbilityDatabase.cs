using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDatabase : MonoBehaviour {
    public GameObject[] mAbilities;

    private static AbilityDatabase mInstance;

    private PlayerScript mPlayerScript;

    public readonly GameObject mAbilityDatabse;

    private AbilityDatabase()
    {
        
    }

    public static AbilityDatabase GetInstance()
    {
        if (mInstance == null)
        {
            mInstance = new AbilityDatabase();
        }
        return mInstance;
    }

    public GameObject GetAbility(uint i)
    {
        if (i > mAbilities.Length || i < 0)
            throw new KeyNotFoundException("Ability ID:" + i + " not found :( ");

        if (mAbilities[i] != null)
            return mAbilities[i];
        else
            throw new KeyNotFoundException("Ability ID:" + i + " not found :( ");
    }

    

}
