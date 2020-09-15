using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoss : MonoBehaviour {


	public GameObject bossPrefab;
	private int collected;
	private bool spawned = false;

	
void SpawnBoss(){

	Instantiate(bossPrefab, new Vector3(8, 5, 0), Quaternion.identity);
}
	// Update is called once per frame
	void Update () {

		collected = GameObject.FindWithTag ("player").GetComponent<AddPoints> ().count5pt;

		if (collected == 0 && spawned == false) {

			Invoke ("SpawnBoss", 2);
			spawned = true;
	}
}
}
