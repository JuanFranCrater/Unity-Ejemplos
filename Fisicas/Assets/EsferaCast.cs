using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaCast : MonoBehaviour {

	Vector3 _posicionInicial;
	float _radioEsfera;
	Vector3 _direccion;
	RaycastHit _hitInfo;
	float _distancia;


	void Start () {
		_radioEsfera = transform.localScale.x / 2F;
		_direccion = Vector3.right;
		_distancia = 100;
	}
	

	void Update () {
		/*
		personaje = gameObject.GetComponent<CharacterController> ();
		*/
		_posicionInicial = transform.position;
		if(Physics.SphereCast(_posicionInicial,_radioEsfera,_direccion,out _hitInfo,_distancia))
		{
			/*
			_hitInfo.collider.gameObject.GetComponent<Renderer>().enabled = false;
			*/
			Debug.Log ("Detectado obstaculo a " + _hitInfo.collider.name );
			Debug.DrawRay (_posicionInicial, _direccion, Color.red);
		}
	}
}
