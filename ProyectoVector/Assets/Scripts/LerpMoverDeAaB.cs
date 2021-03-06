﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMoverDeAaB : MonoBehaviour {


	public Vector3 _origen;
	public Vector3 _destino;
	public float _velocidad;
	public GameObject _objetoM;

	// Use this for initialization
	void Start () {
		_velocidad = 2F;
		_destino = new Vector3 (14,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		_origen = transform.position;
		_objetoM.transform.position = Vector3.Lerp (_origen, _destino, _velocidad * Time.deltaTime);
	}
}
