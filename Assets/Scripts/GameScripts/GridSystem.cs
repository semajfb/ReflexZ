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
    public static int h = 30;
    public static int LOWER_BOUNDS = 0;

    public static int left = w-(w-2);
    public static int right =  w-2;
    public static int bottom = h-(h-2);
    public static int top = h-2;

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
        return ((int)pos.x >= left &&
                (int)pos.x <= right &&
                (int)pos.y >= bottom &&
                (int)pos.y <= top);
    }

    public static bool validateKillZone(float dropTileYPos)
    {
        return dropTileYPos >= 8f && dropTileYPos <= 20f;
    }
}
