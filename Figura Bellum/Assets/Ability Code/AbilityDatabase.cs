using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDatabase : MonoBehaviour {
    public GameObject[] mAbilities;

    private static AbilityDatabase mInstance;

    public readonly GameObject mAbilityDatabse;

    private void Awake()
    {
        mInstance = this;
    }

    public static AbilityDatabase GetInstance()
    {
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
