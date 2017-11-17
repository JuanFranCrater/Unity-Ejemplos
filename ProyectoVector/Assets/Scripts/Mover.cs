using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	float _valorZoom=0;
	float _tamanoZoom=0.5F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal"), 0, 0);
		if (Input.GetAxis ("Fire1") != 0) {
			//Hacer algo
			Debug.Log("Disparando");
		}
		_valorZoom = Input.GetAxis ("Zoom");
		transform.localScale += new Vector3 (_valorZoom * _tamanoZoom, _valorZoom * _tamanoZoom, _valorZoom * _tamanoZoom);

	}
}
