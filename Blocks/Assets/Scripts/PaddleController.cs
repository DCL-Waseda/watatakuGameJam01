using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public float m_accel;
	private float accel;

	public Shot m_shotPrefab;

	private void Start(){
		accel = m_accel;
	}

	// Update is called once per frame
	private void Update () {
		var force = transform.right * Input.GetAxisRaw ("Horizontal") * accel;
		GetComponent<Rigidbody> ().AddForce (force, ForceMode.Impulse);
		if (Input.GetKey (KeyCode.Z)) {
			accel = m_accel * 3.0f;
		} else {
			accel = m_accel;
		}
		if (input.GetKeydown (KeyCode.X)) {
			var pos = transfrom.localPosition;
			var shot = Instantiate (m_shotPrefap, pos);
		}

	}
}
