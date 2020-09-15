using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AddPoints : MonoBehaviour {

	private int score;
	public TextMeshPro scoreText;

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "collectible5pt") {
			Debug.Log ("I collected 5 points");
			Destroy (col.gameObject);
			score += 5;

			scoreText.text = "Score: " + score.ToString ();
		} else if (col.gameObject.tag == "minus10pt") {
			Debug.Log ("I lost 10 points");
			Destroy (col.gameObject);
			score -= 10;
			scoreText.text = "Score: " + score.ToString ();  

		}
}
	void Start (){
		score = 0;
	}

}
