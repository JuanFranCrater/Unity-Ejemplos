using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldeDireccion : MonoBehaviour {

	Transform _cubo;
	float x = 50;
	float y = 100;
	float z = 100;
	float w = -50;
	public bool _sigueAlCubo = false;//Sincroniza la rotacion con el cubo


	void Start () {
		_cubo = GameObject.Find ("Cube").GetComponent<Transform>();	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!_sigueAlCubo) {
			transform.rotation = new Quaternion (x, y, z, w);
		}
		if (ControlCombustible._hayCombustible) {
			_cubo.transform.Rotate (Vector3.up);
		}
	}
}
