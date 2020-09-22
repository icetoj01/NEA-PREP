using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

public AudioClip coin;
private AudioSource source;

	//this will run when the object is first loaded 
	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	//positive collectible is a trigger
	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("bing!");
		source.PlayOneShot (coin,1);

	}
}
