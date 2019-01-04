using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	//Tile
	public GameObject[] dropTiles;
	// Use this for initialization
	void Start () {
		spawnNext();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawnNext() {
		int i = Random.Range(0, dropTiles.Length);

		Instantiate(dropTiles[i],
					transform.position,
					Quaternion.identity);
	}
}
