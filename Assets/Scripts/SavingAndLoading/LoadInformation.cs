using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInformation() {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYER_NAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYER_LEVEL");
        GameInformation.Vitality = PlayerPrefs.GetInt("VITALITY");
        GameInformation.Strength = PlayerPrefs.GetInt("STREGNTH");
        GameInformation.Agility = PlayerPrefs.GetInt("AGILITY");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.MagicalDefense = PlayerPrefs.GetInt("MAGICAL_DEF");
        GameInformation.PhysicalDefense = PlayerPrefs.GetInt("PHYSICAL_DEF");
        Debug.Log("SAVED ALL INFORMATION");
    }

    public static void LoadName()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYER_NAME");
    }

    public static void LoadLevel()
    {
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYER_LEVEL");
    }

    public static void LoadPlayerStats()
    {
        GameInformation.Vitality = PlayerPrefs.GetInt("VITALITY");
        GameInformation.Strength = PlayerPrefs.GetInt("STREGNTH");
        GameInformation.Agility = PlayerPrefs.GetInt("AGILITY");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.MagicalDefense = PlayerPrefs.GetInt("MAGICAL_DEF");
        GameInformation.PhysicalDefense = PlayerPrefs.GetInt("PHYSICAL_DEF");
    }
}
