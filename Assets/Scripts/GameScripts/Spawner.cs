using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    //Tile
    public GameObject[] dropTiles;
    public GameObject spawner;

    // Use this for initialization

    public static List<GameObject> activeTiles;
    void Start()
    {
        StartCoroutine(SpawnDropTiles());
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Awake()
    {
        activeTiles = new List<GameObject>();
    }

    IEnumerator SpawnDropTiles()
    {
        yield return new WaitForSeconds(Random.Range(0, 0.7f));

        // while (true)
        // {
            Vector2 spawnPoint = RandomPointWithinBorders(activeTiles);
			Debug.Log("Spawning Drops");
            int i = Random.Range(0, 10);
            GameObject drop = (GameObject)Instantiate(dropTiles[i], spawnPoint, Quaternion.identity);
           // activeTiles.Add(drop);
       // }
    }


    public Vector2 RandomPointWithinBorders(List<GameObject> activeTiles)
    {
        //Code that will spawn a bouncing ball and ShowSpawn at a random position inside the borders 
        Vector2 random = new Vector2();
        random.y = GridSystem.top;
        random.x = Random.Range(GridSystem.left, GridSystem.right);

        while (activeTiles.Count > 0 && Mathf.Abs(activeTiles[activeTiles.Count - 1].transform.position.x - random.x) < 1)
        {
            random.x = Random.Range(GridSystem.left, GridSystem.right);
        }
        return random;
    }

    // public void spawnNext() {
    // 	int i = Random.Range(0, 10);
    // 	int spawn = Random.Range(2,8);	

    // 	Instantiate(dropTile,
    // 				transform.position = new Vector2(spawn, 30),
    // 				Quaternion.identity);
    // }
}
