using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {


    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int vitality;
    private int stregth;
    private int agility;
    private int intellect;
    private int magicalDefense;
    private int physicalDefense;

    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public int Vitality { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intellect { get; set; }
    public int MagicalDefense { get; set; }
    public int PhysicalDefense { get; set; }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
}
