using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {

    public enum WeaponTypes
    {
        SWORD=1,
        STAFF=2,
        DAGGER=3,
        BOW=4,
        SHIELD=5,
        WAND=6,
        AXE=7,
        CROSSBOW=8,
        SCEPTER=9,
        MACE=10,

}

    private WeaponTypes weaponType;
    private int spellEffectID;


    public WeaponTypes GetWeaponType()
    {
        return weaponType;
    }

    public void SetWeaponType(WeaponTypes value)
    {
        weaponType = value;
    }

    public int SpellEffectID { get; set; }

    public override string ToString()
    {
        return this.GetItemTier() +  " Type : " + weaponType
            + " {Stats [" + Vitality + " " +  Strength + " " + Agility + " " + Intellect+ "]}";
    }
}
