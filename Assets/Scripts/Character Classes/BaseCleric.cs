using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCleric : BaseCharacterClass {

    public BaseCleric(){
		ClassName = "Cleric";
		ClassDescription = "A divine healer";

		Vitality = 12;
		Strength = 10;
		Intellect = 20;
		Agility = 14;
		MagicalDefense = 20;
		PhysicalDefense = 11;

	}

}
