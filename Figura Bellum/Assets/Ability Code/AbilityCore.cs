using UnityEngine;

public abstract class AbilityCore : MonoBehaviour
{
    public Sprite mIcon;

    private float mSpellPower;

    public float defaultCooldown = 30;
    public float cooldown = 0;

    public abstract void Cast();

   
        

    
}