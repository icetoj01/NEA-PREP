using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Navigation : MonoBehaviour {
	public void  ClickedButtonA(){
		Debug.Log ("Button A clicked!");
	}

	public void  ClickedButtonB(){
		Debug.Log ("Button B clicked!");
	}

	public void  ClickedButtonC(){
		Debug.Log ("Button C clicked!");
		Debug.Log ("Exit Clicked");
		Time.timeScale = 1;
	}

	private Canvas mainCanvas;
	public TextMeshPro timer;

	// Use this for initialization
	void Start () {

		mainCanvas = GameObject.FindObjectOfType<Canvas> ();
		mainCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timer.text = Time.fixedTime.ToString ("0.00");

		if (Input.GetKey (KeyCode.Escape)) {

			mainCanvas.enabled = true;
			Time.timeScale = 0f;


		}
	
	}

}
