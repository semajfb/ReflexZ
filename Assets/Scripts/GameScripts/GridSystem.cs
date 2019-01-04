using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public static List<DropTile> tileQueue = new List<DropTile>();

    public static int w = 10;

    public static GameObject border;
    public static Transform borderLeft;
    public static Transform borderRight;
    public static Transform borderBottom;
    public static Transform borderTop;

    public static Transform spawnLine;
    public static int h = 20;
    public static int LOWER_BOUNDS = 0;

    public static int left = w-w;
    public static int right =  w;
    public static int bottom = h-h;
    public static int top = h;

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
        return ((int)pos.x >= w - w &&
                (int)pos.x < w &&
                (int)pos.y >= h - h &&
                (int)pos.y >= h);
    }

    public static bool validateKillZone(Vector2 dropTilePos)
    {
        return ((int)dropTilePos.y >= 4 && (int)dropTilePos.y <= 6);
    }
}
