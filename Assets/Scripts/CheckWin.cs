using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour {

	private int gameScore;
		
	public TextMeshPro timerText;
	//public float myTimer;

	void Update () {
		//finds object named player and then finds script attached to it called AddPoints, then pull out score"
	gameScore = GameObject.FindWithTag("player").GetComponent<AddPoints>().score;
		//Debug.Log ("Game Score: " + gameScore);

		if (gameScore > 10) {
			Debug.Log ("WINNER!");
		}
		else if (gameScore < 0) {
			Debug.Log ("LOSER!");
		}
		timerText.text = "Time: " + Time.fixedTime.ToString ();
		if (timerText = 30) {
			SceneManager.LoadScene (1);
		}
}

	}

