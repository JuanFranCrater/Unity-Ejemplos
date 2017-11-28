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
	void OnCollisionEnter(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Ha colisionado con ..." + colision.gameObject.name);
			colision.gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			;
			if (colision.relativeVelocity.magnitude > 2F) {
			//	Destroy (colision.gameObject);
			}
		} else if(colision.gameObject.tag=="Enemigo") {
			Debug.Log ("Te ha pillado");
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
	}
	void OnCollisionStay(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Colisionando con ..." + colision.gameObject.name);
			if (colision.relativeVelocity.magnitude > 2F) {
			//Destroy (colision.gameObject);
			}
		}
	}
	void OnCollisionExit(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Ha dejado de colisionar con ..." + colision.gameObject.name);
			if (colision.relativeVelocity.magnitude > 2F) {
				//Destroy (colision.gameObject);
			}
		}
	}
	void OnTriggerEnter(Collider otro)
	{
		
	}
	void OnTriggerExit(Collider otro)
	{

	}
	void OnTriggerStay(Collider otro)
	{

	}
}
