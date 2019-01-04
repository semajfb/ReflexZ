using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogue : BaseCharacterClass
{

    public BaseRogue()
    {
        ClassName = "Rpgue";
        ClassDescription = "A deceptive cutthroat";

        Vitality = 12;
        Strength = 15;
        Intellect = 13;
        Agility = 20;
        MagicalDefense = 14;
        PhysicalDefense = 11;

    }

}
