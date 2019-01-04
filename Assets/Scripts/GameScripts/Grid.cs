using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
public static List<DropTile> tileQueue = new List<DropTile>();

    public static int w = 10;
    public static int h = 20;
	public static int LOWER_BOUNDS = 0;

    public static Transform[,] grid = new Transform[w, h];  // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public static Vector2 roundVec2(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }

    public static bool insideBorder(Vector2 pos)
    {
        return ((int)pos.x >= 0 &&
                (int)pos.x < w &&
                (int)pos.y >= 0);
	}

    public static bool validateKillZone(Vector2 dropTilePos)
    {
        return ((int)dropTilePos.x >= 0 &&
            (int)dropTilePos.x < w &&
            (int)dropTilePos.y >= 0 && (int)dropTilePos.y <= 5);
    }
}
