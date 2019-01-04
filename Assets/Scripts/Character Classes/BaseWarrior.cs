using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarrior : BaseCharacterClass {

    public BaseWarrior(){
		ClassName = "Warrior";
		ClassDescription = "A strong powerful warrior";

		Vitality = 20;
		Strength = 18;
		Intellect = 11;
		Agility = 14;
		MagicalDefense = 8;
		PhysicalDefense = 17;

	}

}
