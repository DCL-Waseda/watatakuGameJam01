using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failure : MonoBehaviour {
	public GameObject gameOver;

	private void Start(){
		gameOver.SetActive (false);
	}

	private void OnTriggerEnter(Collider collision){
		if (collision.name.Contains ("Sphere")) {
			Destroy (collision.gameObject);
			gameOver.SetActive (true);
		}
		if (collision.name.Contains ("Block")) {
			Destroy (collision.gameObject);
		}
	}
}
