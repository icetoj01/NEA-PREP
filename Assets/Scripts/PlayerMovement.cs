using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "rightwall"){
			Debug.Log ("I collided with the " + col.gameObject.tag);
		}
		else if (col.gameObject.tag == "leftWall")
		{
			Debug.Log ("I collided with the " + col.gameObject.tag);
		}

		else if (col.gameObject.tag == "floor") {
				Debug.Log ("I collided with the " + col.gameObject.tag);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (new Vector3 (1, 0, 0), ForceMode.Impulse); }

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (new Vector3 (-1, 0, 0), ForceMode.Impulse); }

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector3 (0, 5, 0), ForceMode.Impulse);
			Debug.Log ("Jump Jump!"); }
	}
		
		

}
