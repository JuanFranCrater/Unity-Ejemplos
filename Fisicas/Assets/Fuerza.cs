using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour {

	public float _velocidad = 50F;
	public Rigidbody _rigidBody;
	public float _fuerzaSalto = 20F;
	Vector3 vertical = new Vector3(-0.5F,1F,0.3F);
	float umbralSalto = 0.1F;
	public float fuerzaTorque = 25;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidBody.velocity.y)<umbralSalto) {
			//_rigidBody.AddForce(vertical*_fuerzaSalto, ForceMode.Impulse);
			_rigidBody.AddForce(Vector3.up*_fuerzaSalto, ForceMode.Impulse);
		}
	}

	public void FixedUpdate()
	{
		Vector3 fuerzaEmpuje = new Vector3 (Input.GetAxis("Horizontal")*_velocidad,0,Input.GetAxis("Vertical")*_velocidad);
		_rigidBody.AddForce (fuerzaEmpuje);

		//Fuerza Torque
		if (Input.GetKey(KeyCode.T)) {
			_rigidBody.AddTorque (Vector3.up* fuerzaTorque, ForceMode.Force);
		}
	}
}
