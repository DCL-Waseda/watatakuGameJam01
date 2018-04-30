using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour {

	public float m_speed;
	private float spd_timer = 0.0f;


	// Use this for initialization
	private void Start () {
		var force = (transform.forward + transform.right) * m_speed;
		GetComponent<Rigidbody> ().AddForce (force, ForceMode.VelocityChange);
	}
		
	private void Update(){
		spd_timer += Time.deltaTime;
		if (spd_timer > 1.0f) {
			Rigidbody rigidbody = GetComponent<Rigidbody> ();
			Vector3 vel = rigidbody.velocity;
			if(vel.x <= 5.0f && vel.z <= 5.0f) {
				vel.x *= 1.2f;
				vel.z *= 1.2f;
			}
			rigidbody.velocity = vel;
			spd_timer = 0.0f;
		}
		if (Input.GetKey (KeyCode.X)) {
			spd_timer = 0.0f;
			Rigidbody rigidbody = GetComponent<Rigidbody> ();
			Vector3 vel = rigidbody.velocity;
			vel.x *= 1.2f;
			vel.z *= 1.2f;
			rigidbody.velocity = vel;
		}
	}
}
