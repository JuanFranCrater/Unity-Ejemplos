using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotando : MonoBehaviour {

	float _velicidadRotacion = 2F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (transform.rotation.x + _velicidadRotacion, transform.rotation.y,transform.rotation.z));
		_velicidadRotacion++;
	}
}
