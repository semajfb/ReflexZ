using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYER_LEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYER_NAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("VITALITY", GameInformation.Vitality);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("AGILITY", GameInformation.Agility);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("MAGICAL_DEF", GameInformation.MagicalDefense);
        PlayerPrefs.SetInt("PHYSICAL_DEF", GameInformation.PhysicalDefense);

        Debug.Log("SAVE ALL MY STUFF PLAYER");
    }

    public static void SaveInfoAfterLevelUp() {
        PlayerPrefs.SetInt("PLAYER_LEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("VITALITY", GameInformation.Vitality);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("AGILITY", GameInformation.Agility);
        PlayerPrefs.SetInt("INTELLECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("MAGICAL_DEF", GameInformation.MagicalDefense);
        PlayerPrefs.SetInt("PHYSICAL_DEF", GameInformation.PhysicalDefense);
    }


    public static void SaveInfoBeforeScene()
    {
        //Position
    }

    public static void SaveInfoAfterScene() {
        //Position
    }

    public static void SaveInfoAfterZone() { }

    public static void SaveAtCheckPoint() { }
}
