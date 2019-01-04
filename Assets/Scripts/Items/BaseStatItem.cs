using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem
{
    private int vitality;
    private int strength;
    private int intellect;
    private int agility;
    private int magicalDefense;
    private int physicalDefense;

    private int levelReq;
    //ItemTier class should be an object with certain values, like unique, or locked, or boe etc etc

    public enum ItemTiers 
    {
            COMMON = 1,
            SUPERIOR =2,
            RARE = 3,
            EPIC = 4,
            LENEGDARY =5

    };

    private ItemTiers itemTier;


    //ItemAffix class


    public int Vitality { get; set; }
    public int Strength { get; set; }
    public int Intellect { get; set; }
    public int Agility { get; set; }
    public int MagicalDefense { get; set; }
    public int PhysicalDefense { get; set; }
    public int LevelReq { get; set; }

    public string GetItemTier()
    {
        return itemTier.ToString();
    }

    public void SetItemTier(ItemTiers key)
    {
        itemTier = key;
    }
}
