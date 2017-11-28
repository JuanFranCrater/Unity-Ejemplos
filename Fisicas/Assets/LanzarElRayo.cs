using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarElRayo : MonoBehaviour {
	Vector3 fwd;//forward
	int alcanceRayo=1000;
	GameObject go;
	RaycastHit[] objetosDetectados;

	void Update () {
		
		RaycastHit hit;
		fwd = transform.TransformDirection(Vector3.right*(-1)*alcanceRayo);
		objetosDetectados = Physics.RaycastAll (transform.position, fwd);
		foreach (RaycastHit tmp in objetosDetectados) {
			Debug.Log("Detectado => TIPO: "+tmp.GetType().ToString() +" a una distancia de "+tmp.distance.ToString()+" con un Collider: "+tmp.collider.gameObject.ToString());
		}
		/*
		if (Physics.Raycast (transform.position, fwd, out hit)) {
			
			Debug.Log ("Detectado...");
			hit.collider.gameObject.SetActive (false);
		}
		*/
		Debug.DrawRay (transform.position, fwd,Color.cyan);
		if(Input.GetKey(KeyCode.Space))
		{
			transform.Rotate (Vector3.up);
		}
	}
}
