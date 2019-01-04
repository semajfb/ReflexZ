using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCombatState : MonoBehaviour {
    
    public enum BattleStates
    {
        START,
        PLAYER_CHOICE,
        PLAYER_ACTION,
        ENEMY_CHOICE,
        ENEMY_ACTION,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	// Use this for initialization
	void Start () {
        currentState = BattleStates.START; 
	}

    // Update is called once per frame
    void Update() {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                //SET Up Battle
                break;
            case (BattleStates.PLAYER_CHOICE):
                break;
            case (BattleStates.PLAYER_ACTION):
                break;
            case (BattleStates.ENEMY_CHOICE):
                break;
            case (BattleStates.ENEMY_ACTION):
                break;
            case (BattleStates.WIN):
                break;
            case (BattleStates.LOSE):
                break;
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("DONE"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYER_CHOICE;
            }
            else if (currentState == BattleStates.PLAYER_CHOICE)
            {
                currentState = BattleStates.PLAYER_ACTION;
            }
            else if (currentState == BattleStates.PLAYER_ACTION)
            {
                currentState = BattleStates.ENEMY_CHOICE;
            }
            else if (currentState == BattleStates.ENEMY_CHOICE)
            {
                currentState = BattleStates.ENEMY_ACTION;
            }
            else if (currentState == BattleStates.LOSE)
            {
                currentState = BattleStates.START;
            }
            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}

