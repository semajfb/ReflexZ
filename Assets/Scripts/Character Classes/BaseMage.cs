using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMage : BaseCharacterClass  {

	public BaseMage() {
		ClassName = "Mage";
		ClassDescription = "A magnificent sorceror";

		Vitality = 12;
		Strength = 10;
		Intellect = 20;
		Agility = 12;
		MagicalDefense = 19;
		PhysicalDefense = 8;

	}
}
