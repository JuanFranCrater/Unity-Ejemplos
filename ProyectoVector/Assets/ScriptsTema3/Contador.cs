using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//-------------------------------
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	GameObject _texto;
	Text _contenido;
	float _tiempo= 0.0F;

	void Start () {
		_texto = GameObject.Find ("Texto");	
		_contenido = _texto.GetComponent<Text>();
	}
	
	void Update () {

			_tiempo+=Time.deltaTime;
			_contenido.text = _tiempo.ToString("0000");

	}
}
