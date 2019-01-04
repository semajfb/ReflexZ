using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Vitality { get; set; }
    public static int Strength { get; set; }
    public static int Agility { get; set; }
    public static int Intellect { get; set; }
    public static int MagicalDefense { get; set; }
    public static int PhysicalDefense { get; set; }
}
