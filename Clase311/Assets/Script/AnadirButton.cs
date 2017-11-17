using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnadirButton : MonoBehaviour {

	GameObject _primerButton; //Boton a clonar

	GameObject _padredelosButtons; //Contenido

	// Use this for initialization
	void Start () {
		_primerButton = GameObject.Find ("Button");	
		_padredelosButtons = GameObject.Find ("Contenido");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AnadirBtn()
	{
		Instantiate (_primerButton,_padredelosButtons.GetComponent<Transform>());//Copiamos Button y lo metos en el padre

	}
}

