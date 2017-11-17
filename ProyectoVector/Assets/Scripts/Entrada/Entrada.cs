using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrada : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float esperar = 0F;
	// Update is called once per frame
	void Update () {
		//Basados en el InputManager
		if (Input.GetButton ("Jump")) {
			Debug.Log ("JUMPING");
		}
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("Down");
		}
		//De tipo de string (caracter)
		//no valen letras en mayuscula
		if (Input.GetKey ("a")) {

			Debug.Log ("Has pulsado la a");
		}
		if(Input.GetKey("r")&& Time.time >esperar)
			{
			Debug.Log ("Recargando...");
			esperar = Time.time + 2F; //2 segundos
			}
		//Usando KeyCode
		if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				Debug.Log("Disparando");
			}
		//De tipo Int
		if (Input.GetMouseButton (0)) {
			Debug.Log("Pulsado el click izquierdo")	;
		}
		if (Input.GetMouseButtonDown (1)) {
			Debug.Log("Pulsado el click derecho")	;
		}
	}
}
