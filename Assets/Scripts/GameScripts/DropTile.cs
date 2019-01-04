using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DropTile : MonoBehaviour
{
    public float lastFall = 0;
    private int hp = 50;

    public static List<DropTile> tileQueue = new List<DropTile>();

    // Use this for initialization
    void Start()
    {
        tileQueue.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastFall) >= 1)
        {
            transform.position += new Vector3(0, -1, 0);

            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();

				if(Grid.validateKillZone(new Vector2(transform.position.x, transform.position.y))){
					if(Input.GetKeyDown(KeyCode.Space)){
						hitDropTile();
					}
				}

				if (transform.position.x < 0)
                {
                    missDropTile();
                }
            }
            else
            {
                // It's not valid. revert.
    
                // Spawn next Group
                FindObjectOfType<Spawner>().spawnNext();

                // Disable script
                enabled = false;
            }
            lastFall = Time.time;
        }
    }

    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Grid.roundVec2(child.position);

            // Not inside Border?
            if (!Grid.insideBorder(v))
                return false;
        }
        return true;
    }

    void updateGrid()
    {
        // Remove old children from grid
        for (int y = 0; y < Grid.h; ++y)
            for (int x = 0; x < Grid.w; ++x)
			if (Grid.grid[x, y] != null && Grid.grid[x, y].parent == transform){
                    Grid.grid[x, y] = null;
			}
        // // Add new children to grid
        // foreach (Transform child in transform)
        // {
        //     Vector2 v = Grid.roundVec2(child.position);
        //     Grid.grid[(int)v.x, (int)v.y] = child;
        // }
    }
    public void hitDropTile()
    {
        Grid.grid[(int)transform.position.x, (int)transform.position.y] = null;
        tileQueue.Remove(this);
    }

    public void missDropTile()
    {
        //change hp
        hp = hp - 1;
        tileQueue.Remove(this);
        Grid.grid[(int)transform.position.x, (int) transform.position.y] = null;
    }
}