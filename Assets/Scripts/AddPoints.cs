using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AddPoints : MonoBehaviour {

	public int score;
	public TextMeshPro scoreText;
	public TextMeshPro goodText;
	private GameObject[] collect5ptArray;
	private int count5pt;
	public TextMeshPro badText;
	private GameObject[] collect10ptArray;
	private int count10pt;




	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "minus10pt") {
			Debug.Log ("I lost 10 points");
			Destroy (col.gameObject);
			score -= 10;
			scoreText.text = "Score: " + score.ToString (); 

			count10pt -= 1;
			badText.text = "Bad: " + count10pt.ToString ();
		}
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "collectible5pt") {
			Debug.Log ("I collected 5 points");
			Destroy (col.gameObject);
			score += 5;
			scoreText.text = "Score: " + score.ToString ();
			count5pt -= 1;
			goodText.text = "Good: " + count5pt.ToString ();
		}	 

	}

	void Start (){
		score = 0;

		collect5ptArray = GameObject.FindGameObjectsWithTag ("collectible5pt");
		count5pt = collect5ptArray.Length;
		goodText.text = "Good: " + count5pt.ToString ();

		collect10ptArray = GameObject.FindGameObjectsWithTag ("minus10pt");
		count10pt = collect10ptArray.Length;
		badText.text = "Bad: " + count10pt.ToString ();
	}

	
}
