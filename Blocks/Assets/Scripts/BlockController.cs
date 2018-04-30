using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {
	public float m_speed;

	private void OnCollisionEnter(Collision collision){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		Vector3 vel = rigidbody.velocity;
		vel.z = -3.0f;
		rigidbody.velocity = vel;
	}
}
