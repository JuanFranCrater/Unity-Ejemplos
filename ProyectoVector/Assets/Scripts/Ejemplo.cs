using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour {

	float destino = 3.4F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Los tres hacen lo mismo
		//transform.position = transform.right * destino;
		//transform.position = Vector3.right * destino;
		transform.position = new Vector3 (1, 0, 0) * destino;

	}
}
