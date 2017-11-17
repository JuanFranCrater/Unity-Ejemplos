using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Input.GetAxis ("Mouse Y"), 0, 0);
		transform.Rotate (0,Input.GetAxis ("Mouse X"), 0);
		transform.Translate (0.01F, 0, 0);
	}
}
