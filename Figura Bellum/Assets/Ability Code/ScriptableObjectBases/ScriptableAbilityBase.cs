using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "new_item", menuName = "FiguraBellum/Ability/Ability", order = 1)]
public class ScriptableAbilityBase : ScriptableObject
{
    //The ican that shows on your hotbar.
    public Sprite mIcon;

    //The name of the ability.
    public string mName;

    //The amount of time you have to wait before using this ability again.
    public float mCooldown;

    //The script that this ability will trigger when you use the ability.
    public string mAbilityScript;

    //The abilit(s) that need to be unlocked before this can be unlocked.
    public ScriptableAbilityBase mPrereq;
}
