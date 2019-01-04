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
       // tileQueue.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastFall) >= 0.7)
        {
            transform.position += new Vector3(0, -1.5f, 0);
            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update GridSystem.
                updateGridSystem();

				if(GridSystem.validateKillZone(new Vector2(transform.position.x, transform.position.y))){
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
    
                 //FindObjectOfType<Spawner>().spawnNext();
                // Spawn next Group
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
            Vector2 v = GridSystem.roundVec2(child.position);

            // Not inside Border?
            if (!GridSystem.insideBorder(v))
                return false;
        
        }
        return true;
    }

    void updateGridSystem()
    {
        // Remove old children from GridSystem
        for (int y = 0; y < GridSystem.h; ++y)
            for (int x = 0; x < GridSystem.w; ++x)
			if (GridSystem.grid[x, y] != null && GridSystem.grid[x, y].parent == transform){
                    GridSystem.grid[x, y] = null;
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
        GridSystem.grid[(int)transform.position.x, (int)transform.position.y] = null;
       // tileQueue.Remove(this);
    }

    public void missDropTile()
    {
        //change hp
        hp = hp - 1;
       // tileQueue.Remove(this);
        GridSystem.grid[(int)transform.position.x, (int) transform.position.y] = null;
    }
}