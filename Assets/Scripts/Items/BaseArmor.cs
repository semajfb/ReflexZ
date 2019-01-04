using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmor : BaseStatItem {

    public enum ArmorTypes
    {
        HELM,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        HAND,
        RING_ONE,
        RING_TWO,
        NECK
    }

    private ArmorTypes armorType;
    private int spellEffectID;
    


    public ArmorTypes GetArmorType()
    {
        return armorType;
    }

    public void SetArmorType(ArmorTypes value)
    {
        armorType = value;
    }

    public int SpellEffectID { get; set; }

}
