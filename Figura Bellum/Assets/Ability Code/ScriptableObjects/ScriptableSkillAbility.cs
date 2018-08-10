using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "new_skill_ability", menuName = "FiguraBellum/Ability/Skill", order = 1)]
public class ScriptableSkillAbility
{
    //The flat amount of health you will gain.
    public double mHealthFlatIncrease;

    //The flat amount of damage that will be gained on your abilities.
    public double mDamageFlatIncrease;

    //The health multiplier.
    public double mHealthModifier;

    //The damage multiplier.
    public double mDamageModifier;
}
