using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onCollisionEnter(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Ha colisionado con ..." + colision.gameObject.name);
			if (colision.relativeVelocity.magnitude > 2F) {
				Destroy (colision.gameObject);
			}
		}
	}
	void onCollisionStay(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Colisionando con ..." + colision.gameObject.name);
			if (colision.relativeVelocity.magnitude > 2F) {
				Destroy (colision.gameObject);
			}
		}
	}
	void onCollisionExit(Collision colision)
	{
		if (colision.gameObject.tag == "Pared") {
			Debug.Log ("Ha dejado de colisionar con ..." + colision.gameObject.name);
			if (colision.relativeVelocity.magnitude > 2F) {
				Destroy (colision.gameObject);
			}
		}
	}
}
