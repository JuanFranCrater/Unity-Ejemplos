using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ControladorEventos : MonoBehaviour {

	GameObject _intLuz; //Toggle
	GameObject _luz; //luz direcional

	void Start () {
		//Referencia a la luz de La escena por su tag
		_intLuz = GameObject.FindWithTag ("Interruptor_Luz");//Busca por TAG
		_luz = GameObject.Find ("Directional Light");//Busca por nombre

	}
	
	void Update () {
		InterruptorLuz ();
	}

	public void InterruptorLuz()
	{
		_luz.SetActive (_intLuz.GetComponent<Toggle>().isOn);
	}
}
