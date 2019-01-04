using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadInformation.LoadAllInformation();

        Debug.Log("Player Class: " + GameInformation.PlayerName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Vitality: " + GameInformation.Vitality);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Agility: " + GameInformation.Agility);
        Debug.Log("Player Intellect: " + GameInformation.Intellect);
        Debug.Log("Player MagicalDefense: " + GameInformation.MagicalDefense);
        Debug.Log("Player PhysicalDefense: " + GameInformation.PhysicalDefense);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
