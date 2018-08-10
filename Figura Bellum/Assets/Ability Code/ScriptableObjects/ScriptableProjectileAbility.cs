using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "new_projectile_ability", menuName = "FiguraBellum/Ability/Projectile", order = 1)]
public class ScriptableProjectileAbility
{
    //The damage that the ability does.
    public double mDamage;

    //The projectile that is shot when using this ability.
    public GameObject mProjectile;
}
