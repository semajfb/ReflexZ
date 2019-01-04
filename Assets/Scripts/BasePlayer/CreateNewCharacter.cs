using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isWarriorClass;
    private bool isRogueClass;
    private bool isClericClass;
    private bool isMageClass;
    private bool isRangerClass;
    private string playerName="Enter Name";

    // Use this for initialization
    void Start() {
        newPlayer = new BasePlayer();

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName,15);
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue");
        isClericClass = GUILayout.Toggle(isClericClass, "Cleric");
        isMageClass = GUILayout.Toggle(isMageClass, "Mage");
        isRangerClass = GUILayout.Toggle(isRangerClass, "Ranger");

        if (GUILayout.Button("Create"))
        {
            if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarrior();
            }
            else if (isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRogue();
            }
            else if (isClericClass)
            {
                newPlayer.PlayerClass = new BaseCleric();
            }
            else if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMage();
            }
            else if (isRangerClass)
            {
                newPlayer.PlayerClass = new BaseRanger();
            }


            newPlayer.PlayerLevel = 1;
            newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.MagicalDefense = newPlayer.PlayerClass.MagicalDefense;
            newPlayer.PhysicalDefense = newPlayer.PlayerClass.PhysicalDefense;

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Player Class: " + newPlayer.PlayerClass.ClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Vitality: " + newPlayer.Vitality);
            Debug.Log("Player Strength: " + newPlayer.Strength);
            Debug.Log("Player Agility: " + newPlayer.Agility);
            Debug.Log("Player Intellect: " + newPlayer.Intellect);
            Debug.Log("Player MagicalDefense: " + newPlayer.MagicalDefense);
            Debug.Log("Player PhysicalDefense: " + newPlayer.PhysicalDefense);
        }

        if (GUILayout.Button("Load"))
        {
            Application.LoadLevel("Test");
            Debug.Log("LOADING....");
           // SceneManager.LoadScene("Test");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = 1;
        GameInformation.Vitality = newPlayer.Vitality;
        GameInformation.Strength = newPlayer.PlayerClass.Strength;
        GameInformation.Agility = newPlayer.Agility;
        GameInformation.Intellect = newPlayer.Intellect;
        GameInformation.MagicalDefense = newPlayer.MagicalDefense;
        GameInformation.PhysicalDefense = newPlayer.PhysicalDefense;
    }
}



