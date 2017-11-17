using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour {

	public float _velocidad = 50F;
	public Rigidbody _rigidBody;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody> ();
	}

	public void FixedUpdate()
	{
		Vector3 fuerzaEmpuje = new Vector3 (Input.GetAxis("Horizontal")*_velocidad,0,Input.GetAxis("Vertical")*_velocidad);
		_rigidBody.AddForce (fuerzaEmpuje);
		if (Input.GetKeyDown(KeyCode.Space)) {
			_rigidBody.AddForce(new Vector3(0,10F,0), ForceMode.Impulse);
		}
	
	}
}
