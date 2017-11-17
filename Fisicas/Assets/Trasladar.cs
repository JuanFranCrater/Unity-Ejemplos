using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour {

	public Transform _origen;
	public Transform _direccion;
	float _velocidad = 0.01F;


	void Start () {
		
	}
	

	void Update () {
		_origen.Translate (_direccion.transform.position * _velocidad);	
	}
}
