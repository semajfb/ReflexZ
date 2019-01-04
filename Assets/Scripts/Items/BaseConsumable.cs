using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseConsumable : BaseItem {


    private int spellEffectID;
    private int turnDuration;

    public int SpellEffectID { get; set; }
    public int TurnDuration { get; set;  }
}
