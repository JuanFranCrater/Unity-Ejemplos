using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	Rigidbody _rigidBody;
	public float _fuerza = 10F;
	void Start()
	{
		_rigidBody = GetComponent<Rigidbody> ();
	}
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate (Vector3.up);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate (Vector3.down);
		}
		if (Input.GetKey (KeyCode.Space)) {
			_rigidBody.AddForce(Vector3.forward*_fuerza, ForceMode.Impulse);
		}
	}
}
