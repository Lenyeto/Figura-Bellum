using UnityEngine;

public abstract class AbilityCore : MonoBehaviour
{
    private float mSpellPower;

    public float defaultCooldown = 30;
    public float cooldown = 0;

    public abstract void Cast();

   
        

    
}