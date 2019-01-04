using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {

	private string className;
	private string classDescription;

	private int vitality;
	private int strength;
	private int intellect;
	private int agility;

	private int magicalDefense;
	private int physicalDefense;

	public string ClassName {get;set;}
	public string ClassDescription { get; set;}

    //Stats should be objects which have units that can be manipulated by modifiers and such, Like Base and growth on level etc. 
    public int Vitality{get;set;}
	public int Strength{get;set;}
	public int Intellect{get;set;}
	public int Agility{get;set;}
	public int MagicalDefense{get;set;}
	public int PhysicalDefense{get;set;}


}
