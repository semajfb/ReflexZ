using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DropTile : MonoBehaviour
{
    public float lastFall = 0;
    private int hp = 50;

    // Use this for initialization
    void Start()
    {
        // tileQueue.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastFall) >= 1)
        {
            transform.position += new Vector3(0, -1.5f, 0);
            // See if valid
            removeMissedTiles(transform.gameObject);

            if (transform.position.y < GridSystem.bottom)
            {
                missDropTile(transform.gameObject);
            }

            if (GridSystem.validateKillZone(transform.position.y))
            {
                Debug.Log("Valid killzone");
                if (Input.GetKeyDown("space"))
                {
                    Debug.Log("Killing");

                    hitDropTile(transform.gameObject);
                }
            }


            lastFall = Time.time;
        }
    }

    public void removeMissedTiles(GameObject tile)
    {
            Vector2 v = GridSystem.roundVec2(tile.transform.position);
            // Not inside Border?
            if (!GridSystem.insideBorder(v))
            {
                missDropTile(tile);
            }
    }

    public void hitDropTile(GameObject tile)
    {
       // GridSystem.grid[(int)transform.position.x, (int)transform.position.y] = null;
        Debug.Log("Hit");
        Spawner.activeTiles.Remove(tile);
        Destroy(tile);
    }


    public void missDropTile(GameObject tile)
    {
        Debug.Log("Missed");
        //change hp
        hp = hp - 1;
        Spawner.activeTiles.Remove(tile);
        Destroy(tile);
    }
}